namespace NetSamples.Collections;

public class User : IComparable<User>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Company{ get; set; }
    
    public int CompareTo(User? other)
    {
        if (Id > other?.Id)
        {
            return 1;
        }
        else if (Id < other?.Id)
        {
            return -1;
        }
        return 0;
    }
}