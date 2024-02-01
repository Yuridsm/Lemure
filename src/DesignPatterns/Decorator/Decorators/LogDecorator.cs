using System;

namespace Lemure.DesignPatterns.Decorator.Decorators;

public sealed class LogDecorator<TAggregateRoot> : InMemoryRepositoryAbstractDecorator<TAggregateRoot>
    where TAggregateRoot : IAggregateRoot
{
    public LogDecorator(IInMemoryRepository<TAggregateRoot> inMemoryRepository) : base(inMemoryRepository)
    {
    }

    public override void Add(TAggregateRoot aggregateRoot)
    {
        LogMessage($"Logging {aggregateRoot} in [Add method]");
        base.Add(aggregateRoot);
    }

    public override void Remove(Guid aggregateRootIdentifier)
    {
        LogMessage($"Logging {aggregateRootIdentifier} in [Remove method]");
        base.Remove(aggregateRootIdentifier);
    }

    private void LogMessage(string message) => Console.WriteLine(message);
}