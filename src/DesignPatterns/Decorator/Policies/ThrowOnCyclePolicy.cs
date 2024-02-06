using System;
using System.Collections.Generic;

namespace Lemure.DesignPatterns.Decorator.Policies;

public class ThrowOnCyclePolicy : RepositoryDecoratorCyclePolicy
{
    public override bool ApplicationAllowed(Type type, IList<Type> allTypes)
    {
        return Handler(type, allTypes);
    }

    public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes)
    {
        return Handler(type, allTypes);
    }

    private bool Handler(Type type, IList<Type> allTypes)
    {
        if (allTypes.Contains(type)) throw new InvalidOperationException($"Cycle detected! Type is already a {type.FullName}");
        return true;
    }
}