namespace NetSamples.Switch 
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Select option:");
            Console.WriteLine("1: X + Y");
            Console.WriteLine("2: X - Y");
            Console.WriteLine("3: X * Y");
            Console.WriteLine("4: X / Y");
            Console.WriteLine("5: X ^ 2"); //equivalent y=2
            Console.WriteLine("6: X ^ Y");

            var selectedOperation = Console.ReadLine();

            switch (selectedOperation)
            {
                case "1":
                    Console.WriteLine("1: X + Y");
                    
                    Console.WriteLine("Enter x:");
                    var x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter y:");
                    var y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{x+y}");
                    break;
                case "2":
                    Console.WriteLine("2: X - Y");
                    break;
                case "3":
                    Console.WriteLine("3: X * Y");
                    Console.WriteLine("3: X * Y");
                    break;
                case "4":
                    Console.WriteLine("4: X / Y");
                    break;
                case "5":
                    Console.WriteLine("5: X ^ 2");
                    goto case "6"; //NEVER USE THAT
                case "6":
                    Console.WriteLine("5: X ^ Y");
                    break;
               default:
                   Console.WriteLine("Wrong value");
                   break;
            }

            

        }
    }
}