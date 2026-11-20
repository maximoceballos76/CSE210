using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-1001", 25.99m, 2));
        order1.AddProduct(new Product("USB-C Cable", "UC-2040", 9.50m, 3));

        Address address2 = new Address("Av. Corrientes 1234", "Buenos Aires", "CABA", "Argentina");
        Customer customer2 = new Customer("Lucia Fernandez", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Mechanical Keyboard", "MK-3300", 79.00m, 1));
        order2.AddProduct(new Product("Mouse Pad", "MP-0150", 12.25m, 2));
        order2.AddProduct(new Product("Laptop Stand", "LS-0777", 34.90m, 1));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalCost():F2}");
            Console.WriteLine("----------------------------------------");
        }
    }
}
