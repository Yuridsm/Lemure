namespace SharedKernel.Factory;

public interface IEventHandlerStrategy
{
	void Process(string eventData);
}
