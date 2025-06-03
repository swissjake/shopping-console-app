using System;

namespace shoppingConsoleApp;

public class Inventory
{
    public List<Product> Products { get; set; }


    public Inventory()
    {
        Products = new List<Product>();


        Products.Add(new Product(Guid.NewGuid(), "Shoes", "Shoes", 100, 1, "Product", "Product", "Product"));
        Products.Add(new Product(Guid.NewGuid(), "Shirt", "Shirt", 50, 1, "Product", "Product", "Product"));
        Products.Add(new Product(Guid.NewGuid(), "Pants", "Pants", 75, 1, "Product", "Product", "Product"));
        Products.Add(new Product(Guid.NewGuid(), "Hat", "Hat", 25, 1, "Product", "Product", "Product"));
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        Products.Remove(product);
    }

    public void DisplayProducts()
    {
        foreach (var product in Products)
        {
            if (Products.Count > 0)
            {
                product.DisplayProduct();
            }
            else
            {
                Console.WriteLine("No products found");
            }
        }
    }
}
