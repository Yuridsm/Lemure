using System;

namespace Lemure.DesignPatterns.Decorator;

public interface IInMemoryRepository<TAgregateRoot> where TAgregateRoot : IAggregateRoot
{
    void Add(TAgregateRoot aggregateRoot);
    void Remove(Guid aggregateRootIdentifier);
}