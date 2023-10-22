namespace Lemure.DesignPatterns.Iterator;

internal interface ProfileIterator
{
    Profile GetNext();
    bool HasMore();
}
