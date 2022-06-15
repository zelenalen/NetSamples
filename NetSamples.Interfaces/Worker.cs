namespace NetSamples.Interfaces;

public class Worker : ICanDoSmth
{
    public void DoSmth()
    {
        Console.WriteLine("Worker do smth");
    }
}