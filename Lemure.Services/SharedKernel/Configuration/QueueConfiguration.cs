namespace SharedKernel.Configuration;

public sealed class QueueConfiguration
{
	public string QueueName { get; }
	public Uri Uri { get; }
	public string ClientProvidedName { get; }
	public string ExchangeName { get; }
	public string ExchangeType { get; }
	public string RoutingKey { get; }

	public QueueConfiguration(string queueName,
		string uri,
		string clientProvidedName,
		string exchangeName,
		string exchangeType,
		string routingKey)
	{
		QueueName = queueName;
		Uri = new Uri(uri);
		ClientProvidedName = clientProvidedName;
		ExchangeName = exchangeName;
		ExchangeType = exchangeType;
		RoutingKey = routingKey;
	}
}
