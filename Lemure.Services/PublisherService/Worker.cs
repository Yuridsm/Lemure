using PublisherService.DataModels;
using SharedKernel.GreatNuGet;
using SharedKernel.GreatNuGet.DataModel;
using SharedKernel.GreatNuGet.Publisher;

namespace PublisherService;

public class Worker : BackgroundService
{
	private readonly ILogger<Worker> _logger;

	public Worker(ILogger<Worker> logger)
	{
		_logger = logger;
	}

	private async Task RandomSentToMatera(DefaultPublisher publisher, int quantity = 10)
	{
		Console.WriteLine($"Publishing data to [Matera]");
		for (int i = 0; i < quantity; i++)
		{
			await Task.Delay(5000);

			var randomValue = new Random().NextDouble() * (1_000_000 - 100) + 100;

			#region Business Rule
			var dataModel = new TransferDataModel($"Pedro", randomValue);
			#endregion

			Console.WriteLine($"Writing to RabbitMQ: from {dataModel.Name}");

			var serializedObject = CustomSerializer<TransferDataModel>.GetContent(dataModel);

			publisher.Publish(serializedObject, "matera", "demo-routing-key1");
		}
	}

	private async Task RandomSentToSantander(DefaultPublisher publisher, int quantity = 10)
	{
		Console.WriteLine($"Publishing data to [Santander]");

		for (int i = 0; i < quantity; i++)
		{
			await Task.Delay(5000);

			var randomValue = new Random().NextDouble() * (1_000_000 - 100) + 100;

			#region Business Rule
			var dataModel = new SantanderDataModel($"Yuri Melo", randomValue, "Bruno Lima");
			#endregion

			Console.WriteLine($"Writing to RabbitMQ: from {dataModel.Customer}");

			var serializedObject = CustomSerializer<SantanderDataModel>.GetContent(dataModel);

			publisher.Publish(serializedObject, "santander", "demo-routing-key2");
		}
	}

	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		//while (!stoppingToken.IsCancellationRequested)
		//{
		_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

		using (var boletadorPublisher = new DefaultPublisher())
		{
			Task materaTask = RandomSentToMatera(boletadorPublisher);
			Task santanderTask = RandomSentToSantander(boletadorPublisher);

			await Task.WhenAll(materaTask, santanderTask);

			Console.WriteLine("Ambas as tarefas foram concluídas.");
		}

		await Task.Delay(1000, stoppingToken);
		//}
	}
}
