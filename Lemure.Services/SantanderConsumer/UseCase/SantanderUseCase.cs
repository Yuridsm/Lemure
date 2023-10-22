using SantanderConsumer.DataModel;
using SharedKernel.GreatNuGet;

namespace SantanderConsumer.UseCase;

public class SantanderUseCase : IUseCase<SantanderTransferDataModel>
{
	public void Execute(SantanderTransferDataModel model)
	{
		Console.WriteLine($"Processando Evento do Tipo Santander [SantanderTransferDataModel] - from {model.Customer} to {model.Part}");
	}
}
