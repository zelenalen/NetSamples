namespace NetSample.Inheritance;

public class Doctor : Employee
{
    public string Specialization { get; set; }

    public void Heal(Employee employee)
    {
        
        Console.WriteLine($"Doctor {Id} reported: {employee.Name}-{employee.Id} was healed");
        DoWork();
    }

    
}