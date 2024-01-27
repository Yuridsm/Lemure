using System;
using Lemure.DesignPatterns.Decorator.Product;

namespace Lemure.DesignPatterns.Decorator;

public static class DecoratorDesignPatternClient
{
    public static void Execute()
    {
        Console.WriteLine("DECORATOR DESIGN PATTERN\n\n");
        var shirt = new Shirt(1000, "Shirt");
        BasicShirtDecorator decoratedShirt = new BasicShirtDecorator(shirt);
        
        Console.WriteLine($"Name: {decoratedShirt.GetName()}");
        Console.WriteLine($"price: {decoratedShirt.GetPrice()}");
    }
}