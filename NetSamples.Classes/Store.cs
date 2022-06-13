namespace NetSamples.Classes;

public class Store
{
    public string Address { get; set; }
    public int Id{ get; set; }
    public string Name { get; set; }


    public static string StoreNetworkName;
    public static int Discount { get; private set; }


    static Store()
    {
        Discount = 15;
        Console.WriteLine("hello from static constructor");
    }

    public Store(int id, string address)
    {
        Id = id;
        Address = address;
        Name = $"{Id} - {address} - {Discount}";
        Console.WriteLine("hello from constructor");

    }

    public static decimal CalculatePrice(decimal priceWithoutDiscount)
    { 
        return priceWithoutDiscount * ((100 - Discount) / 100);
    }

    public static void CreateRoute(double initX, double initY)
    {
        Console.WriteLine("Route is creating");
        Console.WriteLine(".");
        Console.WriteLine("..");
        Console.WriteLine("...");
        Console.WriteLine("....");
        Console.WriteLine(".....");
        Console.WriteLine("Route is created. Good travel");
    }

   
}