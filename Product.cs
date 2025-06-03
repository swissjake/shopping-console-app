namespace shoppingConsoleApp;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Category { get; set; }
    public string Brand { get; set; }
    public string Image { get; set; }


    public Product(Guid id, string name, string description, decimal price, int stock, string category, string brand, string image)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        Category = category;
        Brand = brand;
        Image = image;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Stock: {Stock}");
    }




}
