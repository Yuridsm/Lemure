using System;
using System.Collections.Generic;

namespace Lemure.DesignPatterns.Decorator.Decorators;

public abstract class InMemoryRepositoryAbstractDecorator<TAggregateRoot> : IInMemoryRepository<TAggregateRoot>
    where TAggregateRoot : IAggregateRoot
{
    protected internal readonly List<Type> Types = new();
    private readonly IInMemoryRepository<TAggregateRoot> _inMemoryRepository;

    protected InMemoryRepositoryAbstractDecorator(IInMemoryRepository<TAggregateRoot> inMemoryRepository)
    {
        _inMemoryRepository = inMemoryRepository;
        if (_inMemoryRepository is InMemoryRepositoryAbstractDecorator<TAggregateRoot> decorator)
            Types.AddRange(decorator.Types);
    }

    public virtual void Add(TAggregateRoot aggregateRoot) => _inMemoryRepository.Add(aggregateRoot);

    public virtual void Remove(Guid aggregateRootIdentifier) => _inMemoryRepository.Remove(aggregateRootIdentifier);
}