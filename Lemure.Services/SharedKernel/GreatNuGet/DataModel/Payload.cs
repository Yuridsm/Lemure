namespace SharedKernel.GreatNuGet.DataModel;

public class Payload
{
	public Guid Id { get; } = Guid.NewGuid();
	public string Data { get; private set; }

	public Payload(string data)
	{
		Data = data;
	}
}
