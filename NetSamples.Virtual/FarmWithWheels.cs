namespace NetSamples.OOP;

public class FarmWithWheels : GameObject, IMoveable
{
    public void Move(Point finishPoint)
    {
        //blablabla some logic here
        Console.WriteLine();
    }

    public override void Remove()
    {
        throw new NotImplementedException();
    }
}