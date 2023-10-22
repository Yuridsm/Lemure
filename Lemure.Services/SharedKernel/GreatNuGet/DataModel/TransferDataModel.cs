namespace SharedKernel.GreatNuGet.DataModel;

public class TransferDataModel
{
	public Guid Id { get; } = Guid.NewGuid();
	public string Name { get; private set; }
	public double Cash { get; private set; }

	public TransferDataModel(string name, double cash)
	{
		Name = name;
		Cash = cash;
	}
}
