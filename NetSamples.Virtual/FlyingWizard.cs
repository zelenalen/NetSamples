namespace NetSamples.OOP;

public class FlyingWizard : Unit
{
    public override void Move(Point finishPoint)
    {
        Console.WriteLine($"Unit {Name} fly from {CurrentPosition.X}-{CurrentPosition.Y} to {finishPoint.X}-{finishPoint.Y}");
        CurrentPosition = finishPoint;
    }

    public override void Fight(Point attackPoint)
    {
        for (int i = -1; i < 2; i++)
        {
            for (int j = -1; j < 2; j++)
            {
                var realAttackPoint = new Point()
                {
                    X = attackPoint.X + j,
                    Y = attackPoint.Y + i
                };
                base.Fight(realAttackPoint);
            }
        }
    }

    public override void Dead()
    {
        Console.WriteLine($"Wizard {Name} is dead now");
    }
}