namespace NetSamples.StringBuilder
{
    using System.Text;

    public class Program
    {
        static void Main(string[] args)
        {


            var text = "text";

            

            var sb = new StringBuilder(text);
            var sb2 = new StringBuilder("Hello World");

            Console.WriteLine(sb2.ToString());

            sb2.AppendLine("Hello World #2");

            sb2.EnsureCapacity(15000);


            Console.WriteLine(sb2.ToString());

            sb2.Replace("World", "User");
            Console.WriteLine(sb2.ToString());

        }
    }
}