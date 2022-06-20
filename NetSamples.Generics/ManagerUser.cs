namespace NetSamples.Generics;

public class ManagerUser<T,TY> : User<T,TY> 
    where TY : class
{
    public ManagerUser(T id, string name) : base(id, name)
    {
    }
}