namespace Lemure.DesignPatterns.Decorator.Product;

/// <summary>
/// Interface super genérica usada para todo e qualquer produto dentro
/// do meu e-commerce (inteção ao implementar o Decorator Design Pattern).
/// Caso queira uma interface desenhe contratos voltados para categorias
/// específicas de produtos, considere usar o princípio da segregação de interface.
/// </summary>
public interface IProduct
{
    double GetPrice();
    string GetName();
}