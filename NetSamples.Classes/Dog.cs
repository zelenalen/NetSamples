namespace NetSamples.Classes;

public class Dog
{
    public string Name;

    private string _race;

    public string Race
    {
        set
        {
            _race = value;
        }
    }


    public int Age;



    public Dog(string race)
    {
        Race = race;
    }


    public void PrintInfo()
    {
        Console.WriteLine($"{Name}-{_race} --- {Age}.");
    }
}