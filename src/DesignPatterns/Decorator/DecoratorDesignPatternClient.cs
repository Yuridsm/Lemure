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
        PrintedShirtDecorator decoratedPrintedShirt = new PrintedShirtDecorator(shirt);
        AnimePrintShirtDecorator decoratedAnimePrintedShirt = new AnimePrintShirtDecorator(shirt);
        
        Console.WriteLine($"Shirt Price: {shirt.GetPrice()}");
        Console.WriteLine($"Basic Shirt Price: {decoratedShirt.GetPrice()}");
        Console.WriteLine($"Printed Shirt Price: {decoratedPrintedShirt.GetPrice()}");
        Console.WriteLine($"Anime Printed Shirt Price: {decoratedAnimePrintedShirt.GetPrice()}");
    }
}