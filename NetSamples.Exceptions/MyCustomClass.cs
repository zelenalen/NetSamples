namespace NetSamples.Exceptions;

public class MyCustomClass
{
    public int Number { get; set; }

    public MyCustomClass(int number)
    {
        if (number < 0)
        {
            throw new MyCustomException("Number is less than 0");
        }
    }
}