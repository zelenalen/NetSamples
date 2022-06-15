namespace NetSamples.Struct;

public struct Cat
{
    public string Name = "Cat";
    public int Age = 10;
    public int AmountOfLives = 2;

    public Cat()
    {
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name}-{Age}-{AmountOfLives}");
    }
}