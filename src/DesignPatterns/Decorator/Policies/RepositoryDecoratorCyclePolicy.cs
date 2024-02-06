using System;
using System.Collections.Generic;

namespace Lemure.DesignPatterns.Decorator.Policies;

public abstract class RepositoryDecoratorCyclePolicy
{
    public abstract bool TypeAdditionAllowed(Type type, IList<Type> allTypes);
    public abstract bool ApplicationAllowed(Type type, IList<Type> allTypes);
}