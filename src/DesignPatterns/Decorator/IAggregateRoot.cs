using System;

namespace Lemure.DesignPatterns.Decorator;

public interface IAggregateRoot
{
    public Guid Identifier { get; }
}