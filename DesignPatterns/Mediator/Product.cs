using System;

namespace Lemure.DesignPatterns.Mediator
{
    public class Product
    {
        public Guid ProductIdentifier { get; } = Guid.NewGuid();
        public string Name { get; }
        public decimal Price { get; }

        public override string ToString()
        {
            return $"Identifier: {ProductIdentifier}\n" +
                $"Name: {Name}\n" +
                $"Price: {Price}\n";
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
