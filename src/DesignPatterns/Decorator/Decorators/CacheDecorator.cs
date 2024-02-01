using System;
using System.Collections.Generic;

namespace Lemure.DesignPatterns.Decorator.Decorators;

public class CacheDecorator<TAggregateRoot> : InMemoryRepositoryAbstractDecorator<TAggregateRoot>
    where TAggregateRoot : IAggregateRoot
{
    private readonly ICacheStrategy<TAggregateRoot> _cacheStrategy;

    public CacheDecorator(IInMemoryRepository<TAggregateRoot> inMemoryRepository, ICacheStrategy<TAggregateRoot> cacheStrategy)
        : base(inMemoryRepository)
    {
        _cacheStrategy = cacheStrategy;
    }

    public override void Add(TAggregateRoot aggregateRoot)
    {
        base.Add(aggregateRoot);

        // It also adds in Cache
        Console.WriteLine($"Writing in Cache {aggregateRoot} [Add method]");
        _cacheStrategy.SetValue(aggregateRoot.Identifier, aggregateRoot);
    }

    public override void Remove(Guid aggregateRootIdentifier)
    {
        base.Remove(aggregateRootIdentifier);

        // It also remove from cache
        Console.WriteLine($"Removing in Cache {aggregateRootIdentifier} [Remove method]");
        _cacheStrategy.Remove(aggregateRootIdentifier);
    }
}

public interface ICacheStrategy<TResult>
{
    void SetValue(Guid key, TResult value);
    TResult GetValue(Guid key);
    void Remove(Guid key);
    IEnumerable<Guid> ListKeys();
}

public class CacheStrategy<TResult> : ICacheStrategy<TResult>
{
    private readonly Dictionary<Guid, TResult> _cacheStorage = new();

    public TResult GetValue(Guid key)
    {
        return _cacheStorage[key];
    }

    public IEnumerable<Guid> ListKeys()
    {
        foreach (KeyValuePair<Guid, TResult> keyValuePair in _cacheStorage)
            yield return keyValuePair.Key;
    }

    public void Remove(Guid key)
    {
        if (_cacheStorage.ContainsKey(key))
            _cacheStorage.Remove(key);
    }

    public void SetValue(Guid key, TResult value)
    {
        _cacheStorage[key] = value;
    }
}