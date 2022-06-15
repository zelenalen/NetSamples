namespace NetSamples.OOP;

public class SomeMoveableObject : IMoveable, IFightable
{
    public void Move(Point finishPoint)
    {
        
    }

    public void Fight(Point attackPoint)
    {
        throw new NotImplementedException();
    }
}