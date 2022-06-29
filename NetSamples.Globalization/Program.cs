using System.Globalization;

namespace NetSamples.Globalization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentThread = Thread.CurrentThread;

            var cC = currentThread.CurrentCulture;
            var cUiCulture = currentThread.CurrentUICulture;

            var smth = "Hello".ToLower(CultureInfo.CurrentCulture);
            var smth2 = "Hello".ToLowerInvariant();

            var smth3 = double.TryParse(Console.ReadLine(), 
                NumberStyles.Any, 
                new NumberFormatInfo(){NumberDecimalSeparator = "_"}, 
                out var x); 

            Console.WriteLine("Hello, World!");
        }
    }
}