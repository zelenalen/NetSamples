namespace NetSamples.ObjectTypeSample;

public class SomeSpecificClass
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return $"Point X:{X} Y:{Y}";
    }

    public override int GetHashCode()
    {
        return X.GetHashCode() + Y.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (obj is SomeSpecificClass)
        {
            var ssc = (SomeSpecificClass)obj;

            if (X == ssc.X && Y == ssc.Y)
            {
                return true;
            }
        }
        return false;
    }
}