namespace NetSamples.Interfaces;

public class Handler : ICanDoSmth, ISomeSpecificInterface
{
    private int _someValue;

    public void DoSmth()
    {
        Console.WriteLine("Handler do smth");
    }

    void ICanDoSmth.DoSmth()
    {
        Console.WriteLine("ICanDoSmth do smth");
    }

    int ISomeSpecificInterface.SomeValue
    {
        get => _someValue;
        set => _someValue = value;
    }
}