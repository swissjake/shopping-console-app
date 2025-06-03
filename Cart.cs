using System;

namespace shoppingConsoleApp;

public class Cart
{
    public List<Product> Products { get; set; }
    public decimal TotalPrice { get; set; }



    public Cart()
    {
        Products = new List<Product>();
        TotalPrice = 0;
    }

    public void AddProduct(Product product)
    {
        if (product != null)
        {
            Products.Add(product);
            TotalPrice += product.Price;
            Console.WriteLine($"Added {product.Name} to cart");
        }
        else
        {
            Console.WriteLine("Product not found");
        }
    }

    public void RemoveProduct(Product product)
    {
        Products.Remove(product);
        TotalPrice -= product.Price;
    }

    public void ClearCart()
    {
        Products.Clear();
        TotalPrice = 0;
    }

    public void DisplayProducts()
    {
        if (Products.Count > 0)
        {
            foreach (var product in Products)
            {
                product.DisplayProduct();
            }
        }
        else
        {
            Console.WriteLine("No products in cart");
        }
    }

}
