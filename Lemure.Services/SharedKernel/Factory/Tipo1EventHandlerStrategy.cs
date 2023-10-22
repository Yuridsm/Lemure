using SharedKernel.GreatNuGet;
using SharedKernel.GreatNuGet.DataModel;
using SharedKernel.GreatNuGet.UseCase;

namespace SharedKernel.Factory;

public class Tipo1EventHandlerStrategy : IEventHandlerStrategy
{
	public void Process(string eventData)
	{
		Console.WriteLine("Processando Evento do Tipo 1 [TransferDataModel]");

		var model = CustomSerializer<TransferDataModel>.GetDeserializedObject(eventData);

		var useCase = new TransferUseCase();

		useCase.Execute(model);
	}
}
