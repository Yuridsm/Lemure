using SantanderConsumer.DataModel;
using SantanderConsumer.UseCase;
using SharedKernel.Factory;
using SharedKernel.GreatNuGet;

namespace SantanderConsumer.Strategy;

public class SantanderStrategy : IEventHandlerStrategy
{
	public void Process(string eventData)
	{
		Console.WriteLine("Processando Evento do Tipo Santander [SantanderTransferDataModel]");

		var model = CustomSerializer<SantanderTransferDataModel>.GetDeserializedObject(eventData);

		var useCase = new SantanderUseCase();

		useCase.Execute(model);
	}
}
