using SharedKernel.Configuration;
using SharedKernel.GreatNuGet.Consumer;
using SharedKernel.GreatNuGet.DataModel;
using SharedKernel.GreatNuGet.UseCase;

namespace MateraConsumer;

public class Worker : BackgroundService
{
	private readonly ILogger<Worker> _logger;

	public Worker(ILogger<Worker> logger)
	{
		_logger = logger;
	}

	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		var configuration = new QueueConfiguration("transfer",
			"amqp://guest:guest@localhost:5672",
			"Matera Worker Consumer",
			"DemoExchange",
			"direct",
			"demo-routing-key1");

		var transferConsumer = new DefaultConsumer<TransferDataModel>(configuration);

		var useCase = new TransferUseCase();

		while (!stoppingToken.IsCancellationRequested)
		{
			_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

			transferConsumer.Consume(useCase);

			await Task.Delay(1000, stoppingToken);
		}
	}
}
