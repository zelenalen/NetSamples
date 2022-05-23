namespace NetSamples.ConsoleMenuSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("Select option:");
            Console.WriteLine("1 - Base math operations");
            Console.WriteLine("2 - Extended options");

            var selectedBlock = Console.ReadLine();

            switch (selectedBlock)
            {
                case "1":
                    Console.WriteLine("Select option:");
                    Console.WriteLine("1 - X + Y");
                    Console.WriteLine("2 - X - Y");
                    Console.WriteLine("3 - X * Y");
                    Console.WriteLine("4 - X / Y");
                    Console.WriteLine("5 - X ^ 2"); //equivalent y=2
                    Console.WriteLine("6 - X ^ Y");

                    var selectedOperation = Console.ReadLine();
                    if (selectedOperation == "1")
                    {
                        
                    }
                    else if (selectedOperation == "2")
                    {
                        
                    }
                    else if (selectedOperation == "3")
                    {
                        
                    }
                    break;

                case "2":
                    Console.WriteLine("2: X - Y");
                    break;
                default:
                    Console.WriteLine("Incorrect number");
                    break;
            }




        }
    }
}