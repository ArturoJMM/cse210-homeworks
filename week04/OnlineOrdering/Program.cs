using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.ResetColor();
        Console.WriteLine();

        //Create customers and address:
        Address address1 = new Address("383 Orquideas St.", "Lima", "Lima", "Perú");
        Customer customer1 = new Customer("Arturo Mendez", address1);

        Address address2 = new Address("653 Nort St.", "Provo", "UT", "USA");
        Customer customer2 = new Customer("George Smith", address2);

        Address address3 = new Address("453 Elm St.", "Miami", "FL", "USA");
        Customer customer3 = new Customer("Gary Jhons", address3);

        //Creating Products:
        Product product1 = new Product("Laptop Intel Core I9 12th Gen.", "L-1001", 799.99, 1);
        Product product2 = new Product("Mouse Logitec", "M-232", 19.99, 4);
        Product product3 = new Product("Monitor LG Qled 24 inches", "M-2005", 199.99, 3);
        Product product4 = new Product("Keyboard wireless", "K-332", 49.99, 5);
        Product product5 = new Product("VideoBeam 5500lm Samsung", "M-3064", 1099.99, 1);

        //Creating Orders

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product5);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Order order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product2);
        order3.AddProduct(product4);

        //Display Order details
        List<Order> orders = new List<Order>{order1, order2, order3};

        foreach (Order order in orders)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sub Total (before shipping cost): ${order.GetNetCost()}");
            Console.WriteLine($"Shipping Cost: ${order.GetShippingCost()}");
            Console.WriteLine($"Total Cost of the Order: ${order.GetTotalCost()}");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}