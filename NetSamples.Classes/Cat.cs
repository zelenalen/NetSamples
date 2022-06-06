namespace NetSamples.Classes;

public class Cat
{
    public string Name;
    public string Color;
    public int Age;
    public int LifeCount;

    public Cat(int lifeCount=9)
    {
        LifeCount = lifeCount;
    }

    public Cat(string name, int lifeCount = 9) : this(lifeCount)
    {
        Name = name;
    }

    public Cat(string name, string color, int lifeCount = 9) : this(name, lifeCount)
    {
        Color = color;
    }

    public Cat(string name, string color, int age, int lifeCount = 9) 
        : this(name, color, lifeCount)
    {
        //this = new Cat(name, color, lifeCount);
        Age = age;
    }
}