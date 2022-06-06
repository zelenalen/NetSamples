namespace NetSamples.Classes;

class Person
{
    public int Age;
    public bool IsAlive;
    public string Name;
    public const bool IS_HUMAN = true;

    private int _siblingsCount;

    public Person()
    {
    }

    public Person(int age, bool isAlive, string name, int siblingsCount)
    {
        Age = age;
        IsAlive = isAlive;
        Name = name;
        _siblingsCount = siblingsCount;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name}-{Age} --- {IsAlive}. Has {_siblingsCount} siblings");
    }

    public string GetInfo()
    {
        return $"{Name}-{Age} --- {IsAlive}";
    }
}