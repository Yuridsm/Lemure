using System;

namespace Lemure.DesignPatterns.Iterator;

internal class IteratorClient
{
    public void Run()
    {
        var network = new Facebook();

        ProfileIterator profileIterator = new FacebookIterator(network, new Guid("b2c67609-685c-4240-93ce-4dfd00bc7b40"));

        while(profileIterator.HasMore())
        {
            var result = profileIterator.GetNext();
            Console.WriteLine($"ID: {result.ProfileId} Username: {result.Username}");
        }
    }
}
