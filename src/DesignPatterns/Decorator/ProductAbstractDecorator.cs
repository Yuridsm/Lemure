using Lemure.DesignPatterns.Decorator.Product;

namespace Lemure.DesignPatterns.Decorator;

/// <summary>
/// Este decorator abstrato é genérico para as variações de produto.
/// </summary>
public abstract class ProductAbstractDecorator : IProduct
{
    private readonly IProduct _product;

    public ProductAbstractDecorator(IProduct product)
    {
        _product = product;
    }

    public virtual string GetName() => _product.GetName();

    public virtual double GetPrice() => _product.GetPrice();
}