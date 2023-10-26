using Lemure.DesignPatterns.Iterator.Entity;

namespace Lemure.DesignPatterns.Iterator.Contracts;

internal interface IProfileIterator
{
    Profile GetNext();
    bool HasMore();
}
