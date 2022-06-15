namespace NetSamples.Interfaces;

public class SomeComparableType : IComparable<SomeComparableType>
{
   
    public int A { get; set; }
    public int B { get; set; }

    public int CompareTo(SomeComparableType? other)
    {
        //if this will predict other in sort 
        return A.CompareTo(other.A);
    }
}

