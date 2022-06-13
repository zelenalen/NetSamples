namespace NetSample.Inheritance;

public class Employee
{
    protected int _hiddenInt;
    public int Id { get; set; }
    public string Name { get; set; }

    public void DoWork()
    {
        _hiddenInt = 15;
        Console.WriteLine($"Employee {Id} reported: job is done");
    }
}