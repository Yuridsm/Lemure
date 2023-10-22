using RabbitMQ.Client;

namespace SharedKernel.GreatNuGet.Consumer;

public abstract class AbstractDefaultConsumer<T>
	where T : class
{
	protected readonly ConnectionFactory factory = new();
	protected IConnection connection;
	protected IModel channel;
	protected string exchangeName = "DemoExchange";
	protected string routingKey = "demo-routing-key";
	protected string queueName = "DemoQueue";

	public abstract void Consume(IUseCase<T> useCase);
}
