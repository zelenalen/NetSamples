namespace NetSamples.Generics;

public class User<T, TY> 
    //where T : class
    where TY : class
{
    public T Id { get; }
    public TY PasswordHash { get; }
    public static int X { get; set; }
    public static T Y { get; set; }
    
    public string Name { get; }
    
    public User(T id, string name)
    {
        Id = id;
        Name = name;
    }

    public void CalculateHash(TY password)
    {
        Console.WriteLine(password);
    }
}