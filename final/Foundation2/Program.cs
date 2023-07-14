using System;
namespace Foundation2
{
class Program
{
    static void Main(string[] args)
    {
        Product productegg = new Product("Egg", "E12", 2, 12);
        Product productmilk = new Product("Milk", "M1", 4, 1 );
        Product productsunglasses = new Product("Aviator Sunglasses", "AS1", 20, 1);

        Adress adress1 = new Adress("619 Jungle St.", "Burlington", "Kentucky", "USA");
        Adress adress2 = new Adress("170 Juniper Drive", "Blekinge", " ","Sweden" );

        Customer customer1 = new Customer("Mark Whalberg", adress1);
        Customer customer2 = new Customer("Felix Kjegliber", adress2);

        Order order1 = new Order(customer1, new Product[] {productegg, productmilk, productsunglasses});
        Order order2 = new Order(customer2, new Product[] {productsunglasses, productegg});

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalPrice()}");

        Console.WriteLine();
        
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalPrice()}");

    }
}
}