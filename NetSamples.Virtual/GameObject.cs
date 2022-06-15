namespace NetSamples.OOP;

public abstract class GameObject
{
    public Point CurrentPosition { get; set; }

    public abstract void Remove();
}