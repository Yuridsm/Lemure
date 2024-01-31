using System;

namespace Lemure.DesignPatterns.Decorator;

public class Shirt : IAggregateRoot
{
    private double _price;
    private string _name;

    public Shirt(double price, string name)
    {
        Identifier = Guid.NewGuid();
        _price = price;
        _name = name;
    }


    public Guid Identifier { get; private set; }
    public string GetName() => _name;
    public double GetPrice() => _price;

    public override string ToString() => $"Id: {Identifier}, Name: {_name}, Price: {_price}";
}