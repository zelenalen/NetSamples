namespace NetSamples.Exceptions
{
    public class MyCustomException : Exception
    {
        public MyCustomException(string message) : base(message)
        {
            //execute Exception(message) constructor
            Console.WriteLine(message);
        }
    }
}
