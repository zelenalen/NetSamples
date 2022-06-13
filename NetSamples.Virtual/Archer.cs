namespace NetSamples.Virtual;

public class Archer : Unit
{
    public int ArrowsCount { get; set; }

    public override void Fight(Point attackPoint)
    {
        if (ArrowsCount <= 0)
        {
            Console.WriteLine($"Unit {Name} need to have reload");

            ArrowsCount += 15;
            
            Console.WriteLine($"Unit {Name} new arrow amount: {ArrowsCount}");
        }
        else
        {
            ArrowsCount--;
            base.Fight(attackPoint);
        }
    }

    public override void Dead()
    {
        Console.WriteLine($"Archer {Name} is dead now");
    }
}