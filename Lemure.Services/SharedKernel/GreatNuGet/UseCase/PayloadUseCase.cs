using SharedKernel.GreatNuGet.DataModel;

namespace SharedKernel.GreatNuGet.UseCase;

public class PayloadUseCase : IUseCase<Payload>
{
	public void Execute(Payload model)
	{
		Console.WriteLine($"Id: {model.Id}");
	}
}
