using SharedKernel.GreatNuGet.Consumer;
using SharedKernel.GreatNuGet.DataModel;

namespace SharedKernel.GreatNuGet.Worker;

public class MateraWorkerService
{
	private readonly AbstractDefaultConsumer<Payload> _defaultConsumer;
	private readonly IUseCase<Payload> _useCase;

	public MateraWorkerService(AbstractDefaultConsumer<Payload> defaultConsumer, IUseCase<Payload> useCase)
	{
		_defaultConsumer = defaultConsumer;
		_useCase = useCase;
	}

	public void Execute()
	{
		var useCase = _useCase.Execute;

		//_defaultConsumer.Consume(useCase);
	}
}