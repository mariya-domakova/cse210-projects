using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new("John Smith", new("56 Random St.", "New York", "NY", "USA")));

        order1.AddProduct(new("Socks", 656364, 5.00, 3));
        order1.AddProduct(new("Tie", 278446, 8.20, 1));
        order1.AddProduct(new("Jeans", 123456, 38.46, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total price: ${order1.GetTotalPrice()}");
        Console.WriteLine();

        Order order2 = new Order(new("Maria Domakova", new("korp. 1561", "Zelenograd", "Moscow", "Russia")));

        order2.AddProduct(new("Backpack", 987643, 21.99, 1));
        order2.AddProduct(new("Sneakers", 345076, 54.95, 1));

		Console.WriteLine(order2.GetPackingLabel());
		Console.WriteLine(order2.GetShippingLabel());
		Console.WriteLine($"Total price: ${order2.GetTotalPrice()}");
	}
}