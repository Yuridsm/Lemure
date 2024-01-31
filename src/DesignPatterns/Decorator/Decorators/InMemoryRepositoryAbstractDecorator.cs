using System;

namespace Lemure.DesignPatterns.Decorator.Decorators;

public abstract class InMemoryRepositoryAbstractDecorator<TAggregateRoot> : IInMemoryRepository<TAggregateRoot>
    where TAggregateRoot : IAggregateRoot
{
    private readonly IInMemoryRepository<TAggregateRoot> _inMemoryRepository;

    protected InMemoryRepositoryAbstractDecorator(IInMemoryRepository<TAggregateRoot> inMemoryRepository)
        => _inMemoryRepository = inMemoryRepository;

    public virtual void Add(TAggregateRoot aggregateRoot)
    {
        Console.WriteLine("Estou passando um Decorator Object para ser adicionado algum comportamento. Add");
        _inMemoryRepository.Add(aggregateRoot);
    }

    public virtual void Remove(Guid aggregateRootIdentifier)
    {
        Console.WriteLine("Estou passando um Decorator Object para ser adicionado algum comportamento. Remove");
        _inMemoryRepository.Remove(aggregateRootIdentifier);
    }
}