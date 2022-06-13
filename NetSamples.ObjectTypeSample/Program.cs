using System.Runtime.InteropServices;

namespace NetSamples.ObjectTypeSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var smth1 = new SomeSpecificClass()
            {
                X = 5,
                Y = 6
            };

            var smth2 = new SomeSpecificClass()
            {
                X = 5,
                Y = 6
            };

            Console.WriteLine(smth1);

            Console.WriteLine(
                smth1.GetHashCode() == smth2.GetHashCode());

            Console.WriteLine(smth1.Equals(smth2));
        }
    }
}