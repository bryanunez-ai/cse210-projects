using System;

class Program
{
    static void Main(string[] args)
    {
        // Create first order (USA customer)
        Address address1 = new Address("123 Main Street", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", "TECH-001", 999.99m, 1);
        Product product2 = new Product("Wireless Mouse", "TECH-002", 24.99m, 2);
        Product product3 = new Product("USB Cable", "TECH-003", 9.99m, 3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Create second order (International customer)
        Address address2 = new Address("456 Rue de la Paix", "Paris", "Île-de-France", "France");
        Customer customer2 = new Customer("Marie Dubois", address2);
        Order order2 = new Order(customer2);

        Product product4 = new Product("Smartphone", "TECH-004", 799.99m, 1);
        Product product5 = new Product("Phone Case", "TECH-005", 19.99m, 1);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display Order 1
        Console.WriteLine("ORDER 1:");
        Console.WriteLine("========");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("ORDER 2:");
        Console.WriteLine("========");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}