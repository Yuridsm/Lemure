namespace SharedKernel.Factory;

public static class EventHandlerFactory
{
	public static IEventHandlerStrategy CreateEventHandler(string eventType)
	{
		if (eventType == "demo-routing-key")
		{
			return new Tipo1EventHandlerStrategy();
		}
		else if (eventType == "tipo2")
		{
			return new Tipo2EventHandlerStrategy();
		}
		else
		{
			throw new ArgumentException("Tipo de evento não suportado: " + eventType);
		}
	}
}
