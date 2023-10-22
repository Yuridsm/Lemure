using System.Collections.Generic;

namespace Lemure.Generics;

public class ShoppingCart
{
	// My products
	List<Product> prods = new List<Product>
	{
		new Product("Alface", 3.63),
		new Product("Maça", 3.45),
		new Product("Banana", 9.87)
	};

}
