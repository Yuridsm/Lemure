using System;
using Lemure.DesignPatterns.Iterator.Enumerable;
using Lemure.DesignPatterns.Iterator.Iterators;

namespace Lemure.DesignPatterns.Iterator;

internal class IteratorClient
{
    public void Run()
    {
        var network = new Facebook();

        var profileIterator = new FacebookIterator(network, new Guid("0a4ba7ee-05ca-4ca0-b8b4-42af8f12a0a4"));

        while(profileIterator.HasMore())
        {
            var result = profileIterator.GetNext();
            Console.WriteLine($"ID: {result.ProfileId} Username: {result.Username}");
        }
    }
}
