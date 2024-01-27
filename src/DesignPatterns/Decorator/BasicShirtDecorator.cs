using Lemure.DesignPatterns.Decorator.Product;

namespace Lemure.DesignPatterns.Decorator;

public class BasicShirtDecorator : ProductAbstractDecorator
{

    /// <summary>
    /// Este field poderia ser mais específico, isto é, votado apenas para camisetas.
    /// Para alcançar isto, você poderia fazer aplicar o princípio de segregação de interface
    /// criando um novo contrato que implementasse IProduct e adicionasse ações/comportamentos
    /// mais apurados para Shirt, tal como: IShirtProduct : IProduct;
    /// </summary>
    private readonly IProduct _product;

    public BasicShirtDecorator(IProduct product) : base(product)
    {
        _product = product;
    }

    /// <summary>
    /// Adicionamos comportamento extra apenas para um determinado tipo de camisa.
    /// </summary>
    /// <returns>O nome da camisa</returns>
    public override string GetName()
    {
        return base.GetName();
    }

    /// <summary>
    /// Adicionamos comportamento extra apenas para um determinado tipo de camisa.
    /// </summary>
    /// <returns>O preço de um produto</returns>
    public override double GetPrice()
    {
        // Aplica 5% de desconto
        
        return base.GetPrice() - (base.GetPrice() * 0.05f);
    }
}