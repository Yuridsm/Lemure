namespace SharedKernel.GreatNuGet;

public interface IUseCase<T> where T : class
{
	void Execute(T model);
}
