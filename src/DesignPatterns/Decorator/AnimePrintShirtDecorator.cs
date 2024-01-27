using Lemure.DesignPatterns.Decorator.Product;

namespace Lemure.DesignPatterns.Decorator;

public class AnimePrintShirtDecorator : ProductAbstractDecorator
{
    private readonly IProduct _product;

    public AnimePrintShirtDecorator(IProduct product) : base(product)
    {
        _product = product;
    }

    public override double GetPrice()
    {
        return base.GetPrice() + 20;
    }
}