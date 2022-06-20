namespace NetSamples.Generics;

public class RegionalOffice<T>
{
    public T Manager { get; set; }

    public RegionalOffice(T manager)
    {
        Manager = manager;
    }
}