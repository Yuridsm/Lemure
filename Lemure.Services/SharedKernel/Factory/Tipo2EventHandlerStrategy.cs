namespace SharedKernel.Factory;

public class Tipo2EventHandlerStrategy : IEventHandlerStrategy
{
	public void Process(string eventData)
	{
		Console.WriteLine($"Processando Evento do Tipo 2");
	}
}
