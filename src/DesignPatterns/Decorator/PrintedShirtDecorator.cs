using Lemure.DesignPatterns.Decorator.Product;

namespace Lemure.DesignPatterns.Decorator;

public class PrintedShirtDecorator : ProductAbstractDecorator
{
    private readonly IProduct _product;

    public PrintedShirtDecorator(IProduct product) : base(product)
    {
        _product = product;
    }

    public override double GetPrice()
    {
        return base.GetPrice() + 10;
    }
}