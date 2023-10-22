using SharedKernel.GreatNuGet.DataModel;

namespace SharedKernel.GreatNuGet.UseCase;

public class TransferUseCase : IUseCase<TransferDataModel>
{
	public void Execute(TransferDataModel model)
	{
		if (model.Cash >= 500_000d)
		{
			Console.WriteLine($"{model.Id} is rich     | Cash: {model.Cash}");
		}
		else
		{
			Console.WriteLine($"{model.Id} is not rich | Cash: {model.Cash}");
		}
	}
}
