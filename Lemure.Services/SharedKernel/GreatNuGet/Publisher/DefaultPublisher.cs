using System.Text;
using RabbitMQ.Client;

namespace SharedKernel.GreatNuGet.Publisher;

public class DefaultPublisher : AbstractDefaultPublisher, IDisposable
{
	public DefaultPublisher()
	{
		factory.Uri = new Uri("amqp://guest:guest@localhost:5672");
		factory.ClientProvidedName = "Worker Publisher";

		connection = factory.CreateConnection();
		channel = connection.CreateModel();

		channel.ExchangeDeclare(exchangeName, ExchangeType.Direct);
		channel.QueueDeclare(queueName, false, false, false, null);
		channel.QueueBind(queueName, exchangeName, routingKey, null);
	}

	public override void Publish(string message, string queueName, string customRoutingKey)
	{
		byte[] messageBody = Encoding.UTF8.GetBytes(message);
		channel.BasicPublish(exchangeName, customRoutingKey, null, messageBody);
	}

	private void CloseQueue()
	{
		if (channel != null && channel.IsOpen)
		{
			channel.Close();
		}

		if (connection != null && connection.IsOpen)
		{
			connection.Close();
		}
	}

	public void Dispose() => CloseQueue();
}