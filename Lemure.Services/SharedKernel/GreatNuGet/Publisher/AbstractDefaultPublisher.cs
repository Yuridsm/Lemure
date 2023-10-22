using RabbitMQ.Client;

namespace SharedKernel.GreatNuGet.Publisher;

public abstract class AbstractDefaultPublisher
{
	protected readonly ConnectionFactory factory = new();
	protected IConnection connection;
	protected IModel channel;
	protected string exchangeName = "DemoExchange";
	protected string routingKey = "";
	protected string queueName = "DemoQueue";

	public abstract void Publish(string message, string queueName, string customRoutingKey);
}
