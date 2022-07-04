namespace NetSamples.SortByParameter;

public class SomeClassAComparer : IComparer<SomeClass>
{
    public int Compare(SomeClass x, SomeClass y)
    {
        if (y.A < x.A)
        {
            return 1;
        }
        if (y.A == x.A)
        {
            return 0;
        }
        else
            return -1;
    }
}

public class SomeClassBComparer : IComparer<SomeClass>
{
    public int Compare(SomeClass x, SomeClass y)
    {
        if (y.B < x.B)
        {
            return 1;
        }
        if (y.B == x.B)
        {
            return 0;
        }
        else
            return -1;

    }
}
