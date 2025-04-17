using System;

class Program
{
    static void Main(string[] args)
    {
        // — First Order (domestic) —
        var address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        var customer1 = new Customer("Alice Johnson", address1);
        var order1    = new Order(customer1);
        order1.AddProduct(new Product("Widget",   "W123", 19.99, 2));
        order1.AddProduct(new Product("Gadget",   "G456",  9.99, 5));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine(new string('-', 40));

        // — Second Order (international) —
        var address2 = new Address("456 Globex Ave", "Capital City", "ON", "Canada");
        var customer2 = new Customer("Bob Smith", address2);
        var order2    = new Order(customer2);
        order2.AddProduct(new Product("Thingamajig", "T789", 14.50, 3));
        order2.AddProduct(new Product("Doohickey",   "D012",  4.75,10));
        order2.AddProduct(new Product("Whatsit",     "W345",  7.25, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}
