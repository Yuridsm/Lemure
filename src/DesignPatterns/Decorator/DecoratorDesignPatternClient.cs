using System;
using Lemure.DesignPatterns.Decorator.Decorators;

namespace Lemure.DesignPatterns.Decorator;

public static class DecoratorDesignPatternClient
{
    public static void Execute()
    {
        Console.WriteLine("DECORATOR DESIGN PATTERN\n");
        var shirt1 = new Shirt(1000, "Shirt1");
        var shirt2 = new Shirt(2000, "Shirt2");
        
        var inMemoryRepository = new InMemoryRepository();
        inMemoryRepository.Add(shirt1);

        var logDecorator = new LogDecorator<Shirt>(inMemoryRepository);
        var kafkaBrokerPublisherDecorator = new KafkaBrokerPublisherDecorator<Shirt>(logDecorator);
        
        kafkaBrokerPublisherDecorator.Add(shirt2);

        foreach (var index in inMemoryRepository._shirts)
            Console.WriteLine(index);
    }
}