namespace Lemure.DesignPatterns.Decorator.Product;

public class Shirt : IProduct
{
    private readonly double _price;
    private readonly string _name;

    public Shirt(double price, string name)
    {
        _price = price;
        _name = name;
    }

    public string GetName() => _name;

    public double GetPrice() => _price;
}