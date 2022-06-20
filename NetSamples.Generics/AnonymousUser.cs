namespace NetSamples.Generics;

public class AnonymousUser : User<int, string>
{
    public AnonymousUser(int id, string name) : base(id, name)
    {
    }
}