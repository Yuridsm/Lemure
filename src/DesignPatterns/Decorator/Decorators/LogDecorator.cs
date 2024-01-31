using System;

namespace Lemure.DesignPatterns.Decorator.Decorators;

public sealed class LogDecorator<TAggregateRoot> : InMemoryRepositoryAbstractDecorator<TAggregateRoot>
    where TAggregateRoot : IAggregateRoot
{
    private readonly IInMemoryRepository<TAggregateRoot> _inMemoryRepository;

    public LogDecorator(IInMemoryRepository<TAggregateRoot> inMemoryRepository) : base(inMemoryRepository)
        => _inMemoryRepository = inMemoryRepository;

    public void AddWithLog(TAggregateRoot aggregateRoot)
    {
        LogMessage();
        _inMemoryRepository.Add(aggregateRoot);
    }

    public void RemoveWithLog(Guid aggregateRootIdentifier)
    {
        LogMessage();
        _inMemoryRepository.Remove(aggregateRootIdentifier);
    }

    private void LogMessage() => Console.WriteLine("Adicionando ao log. Remove.");
}