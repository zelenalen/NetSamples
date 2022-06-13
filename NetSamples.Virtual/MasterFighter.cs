namespace NetSamples.Virtual;

public class MasterFighter : Fighter
{
    public int CritAttackChance { get; set; }

    //override by default for child classes is equivalent with virtual
    //sealed - no other override for child classes
    public sealed override void Fight(Point attackPoint)
    {
        CritAttackChance++;
        if (CritAttackChance == 100)
        {
            Console.WriteLine("Unit kill enemy");
            return;
        }
        base.Fight(attackPoint);
    }
}