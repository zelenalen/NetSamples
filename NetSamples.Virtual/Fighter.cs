namespace NetSamples.Virtual;

public class Fighter : Unit
{
    public override void Fight(Point attackPoint)
    {
        var deltaX = Math.Abs(attackPoint.X - CurrentPosition.X);
        var deltaY = Math.Abs(attackPoint.Y - CurrentPosition.Y);

        if (deltaX >1 || deltaY>1)
        {
            Console.WriteLine("Need to go closer");
            Move(attackPoint);
            Fight(attackPoint);
        }
        else
        {
            base.Fight(attackPoint);
        }
    }

    public new void Heal()
    {
        HealthPoint = 5;
    }

    public override void Dead()
    {
        Console.WriteLine($"Fighter {Name} is dead now");
    }
}