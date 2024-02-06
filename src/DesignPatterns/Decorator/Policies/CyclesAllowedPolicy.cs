using System;
using System.Collections.Generic;

namespace Lemure.DesignPatterns.Decorator.Policies;

public class CyclesAllowedPolicy : RepositoryDecoratorCyclePolicy
{
    public override bool ApplicationAllowed(Type type, IList<Type> allTypes) => true;

    public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes) => true;
}