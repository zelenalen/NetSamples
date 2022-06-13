namespace NetSample.Inheritance;

public class Miner : Employee
{
    public void Mine()
    {
        Console.WriteLine($"Miner {Id} reported: I got a diamond");
    }
}