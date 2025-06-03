
using shoppingConsoleApp;

public class Program
{
    private static List<User> users = new List<User>();
    private static bool isLoggedIn = false;

    public static void Main(string[] args)
    {
        users.Add(new User("John Doe", "john@example.com", "password123"));
        users.Add(new User("Jane Smith", "jane@example.com", "password456"));
        users.Add(new User("Alice Johnson", "alice@example.com", "password789"));
        users.Add(new User("Bob Brown", "bob@example.com", "password101"));
        users.Add(new User("Charlie Davis", "charlie@example.com", "password121"));
        users.Add(new User("Diana White", "diana@example.com", "password141"));
        users.Add(new User("Eve Green", "eve@example.com", "password161"));


        ShowShoppingMenu();
        static void ShowShoppingMenu()
        {



            while (!isLoggedIn)
            {
                Console.WriteLine("Welcome to the Shopping Console App!");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.Write("Choose an option (1-2): ");
                string choice = Console.ReadLine();
                Console.WriteLine("You chose: " + choice);

                if (choice == "1")
                {
                    Login();
                }
                else if (choice == "2")
                {
                    Register();
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }


            }
            ProductMenu();


        }

        static void Login()
        {
            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            if (users.Any(user => user.Email == email && user.Password == password))
            {
                Console.WriteLine("Login successful");
                isLoggedIn = true;
            }
            else
            {
                Console.WriteLine("Login failed");
                isLoggedIn = false;
            }
        }

        static void Register()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            users.Add(new User(name, email, password));
            Console.WriteLine("Registration successful");

            if (users.Exists(user => user.Email == email))
            {
                Console.WriteLine("Email already exists");
            }
            else
            {
                users.Add(new User(name, email, password));
                Console.WriteLine("Registration successful");
            }

        }

        static void ProductMenu()
        {
            Cart cart = new Cart();
            Inventory inventory = new Inventory();
            bool continueShopping = true;
            while (continueShopping)
            {
                Console.WriteLine("\nWelcome to the Product Menu!");
                Console.WriteLine("1. List all products");
                Console.WriteLine("2. View cart");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option (1-3): ");

                switch (Console.ReadLine())
                {
                    case "1":
                        inventory.DisplayProducts();
                        Console.WriteLine("\nWhich product do you want to add to your cart? (Enter product ID)");
                        if (Guid.TryParse(Console.ReadLine(), out Guid productId))
                        {
                            Product productToAdd = inventory.Products.FirstOrDefault(p => p.Id == productId);
                            cart.AddProduct(productToAdd);
                        }
                        else
                        {
                            Console.WriteLine("Invalid product ID format");
                        }
                        break;
                    case "2":
                        cart.DisplayProducts();
                        break;
                    case "3":
                        continueShopping = false;
                        Console.WriteLine("Thank you for shopping with us!");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}