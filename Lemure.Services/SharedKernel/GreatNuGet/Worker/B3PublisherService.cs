using SharedKernel.GreatNuGet.DataModel;
using SharedKernel.GreatNuGet.Publisher;

namespace SharedKernel.GreatNuGet.Worker;

public class B3PublisherService
{
	private readonly AbstractDefaultPublisher _abstractDefaultPublisher;

	public B3PublisherService(AbstractDefaultPublisher abstractDefaultPublisher)
	{
		_abstractDefaultPublisher = abstractDefaultPublisher;
	}

	public void UseCase(int times)
	{
		for (int i = 0; i < times; i++)
		{
			var randomValue = new Random().NextDouble() * (1_000_000 - 100) + 100;

			var dataModel = new TransferDataModel($"Any name here {Guid.NewGuid()}", randomValue);

			Console.WriteLine($"Writing to RabbitMQ: {dataModel.Id}");

			var serializedObject = CustomSerializer<TransferDataModel>.GetContent(dataModel);

			//_abstractDefaultPublisher.Publish(serializedObject);
		}
	}

	public void UseCase2(int times)
	{
		for (int i = 0; i < times; i++)
		{
			var dataModel = new Payload($"Any name here {Guid.NewGuid()}");

			Console.WriteLine($"Writing to RabbitMQ: {dataModel.Id}");

			var serializedObject = CustomSerializer<Payload>.GetContent(dataModel);

			//_abstractDefaultPublisher.Publish(serializedObject);
		}
	}
}
