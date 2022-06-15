namespace NetSamples.OOP;

public abstract class Unit : GameObject, IFightableAndMovable
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public int HealthPoint { get; set; }


    public virtual void Move(Point finishPoint)
    {
        Console.WriteLine($"Unit {Name} go from {CurrentPosition.X}-{CurrentPosition.Y} to {finishPoint.X}-{finishPoint.Y}");
        CurrentPosition = finishPoint;
    }

    public virtual void Fight(Point attackPoint)
    {
        Console.WriteLine($"Unit {Name} attack unit in {attackPoint.X}-{attackPoint.Y}");
    }

    public void Heal()
    {
        HealthPoint++;
    }

    public abstract void Dead();

    public void Report()
    {
        Console.WriteLine($"Unit {Name} in {CurrentPosition.X}-{CurrentPosition.Y} - {HealthPoint}");
    }

    public override void Remove()
    {
        
    }
}