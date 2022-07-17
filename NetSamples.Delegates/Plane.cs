namespace NetSamples.Delegates;

public class Plane
{
    public static decimal CalculateFlightCost(int distance)
    {
        var cost = distance * 5;
        Console.WriteLine(cost);
        return cost;
    }
}