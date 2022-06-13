namespace NetSample.Inheritance;

public class Pathologist : Doctor
{
    private bool CheckIsAlive(Employee employee)
    {
        var coin = (new Random()).Next(0, 1);
        
        return coin != 0;
    }

    public void CheckEmployee(Employee employee)
    {
        if (CheckIsAlive(employee))
        {
            Console.WriteLine($"Pathologist {Id} reports: {employee.Name}-{employee.Id} is alive");
        }
        else
        {
            Console.WriteLine($"Pathologist {Id} reports: {employee.Name}-{employee.Id} is dead");
            Console.WriteLine("Use necromancy");
            Heal(employee);
        }

    }
}