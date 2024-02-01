using System;
using Lemure.DesignPatterns.Decorator.Decorators;

namespace Lemure.DesignPatterns.Decorator;

public static class DecoratorDesignPatternClient
{
    public static void Execute()
    {
        Console.WriteLine("DECORATOR DESIGN PATTERN\n");

        // Apply Log in this group
        var shirt1 = new Shirt(1000, "Shirt1");
        var shirt2 = new Shirt(2000, "Shirt2");
        
        // Apply log and send to Kafka Broker this group
        var shirt3 = new Shirt(3000, "Shirt3");
        var shirt4 = new Shirt(4000, "Shirt4");

        // Apply log and chage it this element
        var shirt5 = new Shirt(5000, "Shirt5");
        var shirt6 = new Shirt(6000, "Shirt6");

        // Storage and Cache Strategy
        var inMemoryRepository = new InMemoryRepository();
        var cacheStrategy = new CacheStrategy<Shirt>();
        
        // Logging Decorator
        var logDecorator = new LogDecorator<Shirt>(inMemoryRepository);
        logDecorator.Add(shirt1);
        logDecorator.Add(shirt2);
        logDecorator.Remove(shirt1.Identifier);
        
        // Send to kafka Broker
        var kafkaBrokerPublisherDecorator = new KafkaBrokerPublisherDecorator<Shirt>(inMemoryRepository);
        kafkaBrokerPublisherDecorator.Add(shirt3);
        kafkaBrokerPublisherDecorator.Add(shirt4);
        kafkaBrokerPublisherDecorator.Remove(shirt3.Identifier);
        
        var cacheDecorator = new CacheDecorator<Shirt>(kafkaBrokerPublisherDecorator, cacheStrategy);
        cacheDecorator.Add(shirt5);
        cacheDecorator.Add(shirt6);
        cacheDecorator.Remove(shirt5.Identifier);

        // foreach (var index in cacheStrategy.ListKeys())
        //     Console.WriteLine(cacheStrategy.GetValue(index));
    }
}