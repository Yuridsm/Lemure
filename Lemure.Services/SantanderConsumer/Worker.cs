using SantanderConsumer.DataModel;
using SantanderConsumer.UseCase;
using SharedKernel.Configuration;
using SharedKernel.GreatNuGet.Consumer;

namespace SantanderConsumer;

public class Worker : BackgroundService
{
	private readonly ILogger<Worker> _logger;

	public Worker(ILogger<Worker> logger)
	{
		_logger = logger;
	}

	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		var configuration = new QueueConfiguration("santander",
			"amqp://guest:guest@localhost:5672",
			"Santander Worker Consumer",
			"DemoExchange",
			"direct",
			"demo-routing-key2");

		var transferConsumer = new DefaultConsumer<SantanderTransferDataModel>(configuration);

		var useCase = new SantanderUseCase();

		while (!stoppingToken.IsCancellationRequested)
		{
			_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

			transferConsumer.Consume(useCase);

			await Task.Delay(1000, stoppingToken);
		}
	}
}
