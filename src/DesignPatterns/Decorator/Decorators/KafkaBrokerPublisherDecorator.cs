using System;

namespace Lemure.DesignPatterns.Decorator.Decorators;

public class KafkaBrokerPublisherDecorator<TAggregateRoot> : InMemoryRepositoryAbstractDecorator<TAggregateRoot>
    where TAggregateRoot : IAggregateRoot
{
    private readonly IInMemoryRepository<TAggregateRoot> _inMemoryRepository;

    public KafkaBrokerPublisherDecorator(IInMemoryRepository<TAggregateRoot> inMemoryRepository) : base(inMemoryRepository)
    {
        _inMemoryRepository = inMemoryRepository;
    }

    public void SendMessageToAnotherBoundedContext()
    {
        Console.WriteLine("Enviando evento para outro Bounded Context.");
    }

    public override void Add(TAggregateRoot aggregateRoot)
    {
        SendMessageToAnotherBoundedContext();
        _inMemoryRepository.Add(aggregateRoot);
    }
}