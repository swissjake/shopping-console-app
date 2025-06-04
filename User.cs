using System;

namespace shoppingConsoleApp;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }



    public User(string name, string email, string password)
    {
        Name = name;
        Email = email;
        Password = password;
    }


    public void DisplayUser()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Password: {Password}");
    }




}
