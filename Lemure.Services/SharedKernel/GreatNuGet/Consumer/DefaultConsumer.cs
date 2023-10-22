using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using SharedKernel.Configuration;

namespace SharedKernel.GreatNuGet.Consumer;

public class DefaultConsumer<TDataModel> : AbstractDefaultConsumer<TDataModel>
	where TDataModel : class
{
	private readonly QueueConfiguration _configuration;

	public DefaultConsumer(QueueConfiguration configuration)
	{
		factory.Uri = configuration.Uri; //"amqp://guest:guest@localhost:5672"
		factory.ClientProvidedName = configuration.ClientProvidedName;// "Matera Worker Consumer"

		connection = factory.CreateConnection();
		channel = connection.CreateModel();

		channel.ExchangeDeclare(configuration.ExchangeName, configuration.ExchangeType); // ExchangeType
		channel.QueueDeclare(configuration.QueueName, false, false, false, null);
		channel.QueueBind(configuration.QueueName, configuration.ExchangeName, configuration.RoutingKey, null);
		channel.BasicQos(0, 1, false);
		_configuration = configuration;
	}

	public override void Consume(IUseCase<TDataModel> useCase)
	{
		var consumer = new EventingBasicConsumer(channel);

		consumer.Received += (sender, args) =>
		{
			var body = args.Body.ToArray();

			string message = Encoding.UTF8.GetString(body);

			var desserializedObject = CustomSerializer<TDataModel>.GetDeserializedObject(message);

			useCase.Execute(desserializedObject);

			channel.BasicAck(args.DeliveryTag, false);
		};

		string consumerTag = channel.BasicConsume(_configuration.QueueName, false, consumer);

		Console.WriteLine("Press [enter] to exit");
		Console.ReadLine();

		channel.BasicCancel(consumerTag);
	}
}