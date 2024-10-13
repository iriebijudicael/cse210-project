using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create products
        Product product1 = new Product("Laptop", "DELL", 3340, 2);
        Product product2 = new Product("Mouse", "Longic", 29.78, 1);
        Product product3 = new Product("Keyboard", "KM00", 49.99m, 1);

        // Create addresses
        Address usAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Address internationalAddress = new Address("456 Avenue", "Abidjan", null, "Ivory Coast");

        // Create customers
        Customer usCustomer = new Customer("Judicael", usAddress);
        Customer internationalCustomer = newCustomer("Eric", internationalAddress);

        Order order1 = new Order(usCustomer);
        order1.Products.Add(product1);
        order1.Products.Add(product2);

        Order order2 = new Order(internationalCustomer);
        order2.Products.Add(product2);
        order2.Products.Add(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");
    }
}