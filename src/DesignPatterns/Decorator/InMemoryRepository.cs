using System;
using System.Collections.Generic;
using System.Linq;

namespace Lemure.DesignPatterns.Decorator;

public class InMemoryRepository : IInMemoryRepository<Shirt>
{
    public readonly List<Shirt> _shirts = new();

    public void Add(Shirt aggregateRoot)
    {
        _shirts.Add(aggregateRoot);
    }

    public void Remove(Guid aggregateRootIdentifier)
    {
        var shirt = _shirts.FirstOrDefault(o => o.Identifier == aggregateRootIdentifier);
        
        if (shirt is null) return;

        _shirts.Remove(shirt);
    }
}