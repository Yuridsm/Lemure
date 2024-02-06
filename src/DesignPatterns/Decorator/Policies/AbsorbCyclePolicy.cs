using System;
using System.Collections.Generic;

namespace Lemure.DesignPatterns.Decorator.Policies;

public class AbsorbCyclePolicy : RepositoryDecoratorCyclePolicy
{
    public override bool ApplicationAllowed(Type type, IList<Type> allTypes)
        => !allTypes.Contains(type);

    public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes)
        => true;
}