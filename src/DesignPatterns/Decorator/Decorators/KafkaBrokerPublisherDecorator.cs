using System;

namespace Lemure.DesignPatterns.Decorator.Decorators;

public class KafkaBrokerPublisherDecorator<TAggregateRoot> : InMemoryRepositoryAbstractDecorator<TAggregateRoot>
    where TAggregateRoot : IAggregateRoot
{
    public KafkaBrokerPublisherDecorator(IInMemoryRepository<TAggregateRoot> inMemoryRepository) : base(inMemoryRepository)
    {
    }

    public void SendMessageToAnotherBoundedContext(string message)
    {
        Console.WriteLine(message);
    }

    public override void Add(TAggregateRoot aggregateRoot)
    {
        SendMessageToAnotherBoundedContext($"Enviando evento com Id: {aggregateRoot.Identifier} para outro Bounded Context de adição.");
        base.Add(aggregateRoot);
    }

    public override void Remove(Guid aggregateRootIdentifier)
    {
        SendMessageToAnotherBoundedContext($"Enviando evento com Id: {aggregateRootIdentifier} para outro Bounded Context de subtração.");
        base.Remove(aggregateRootIdentifier);
    }
}