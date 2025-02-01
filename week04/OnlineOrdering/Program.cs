using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Shelbyville", "KY", "USA");
        Address address3 = new Address("789 Maple St", "Ogdenville", "NH", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("Bob Johnson", address3);

        // Create orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);

        // Add products to orders
        order1.AddProduct(new Product("Widget", "W123", 10.00m, 2));
        order1.AddProduct(new Product("Gadget", "G456", 15.00m, 1));

        order2.AddProduct(new Product("Thingamajig", "T789", 20.00m, 3));
        order2.AddProduct(new Product("Doodad", "D012", 5.00m, 4));

        order3.AddProduct(new Product("Gizmo", "G321", 30.00m, 1));
        order3.AddProduct(new Product("Widget", "W123", 10.00m, 2));

        // Display order information
        DisplayOrderInfo(order1);
        DisplayOrderInfo(order2);
        DisplayOrderInfo(order3);
    }

    static void DisplayOrderInfo(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("\nTotal Cost:");
        Console.WriteLine($"${order.CalculateTotalCost():F2}\n");
    }

}