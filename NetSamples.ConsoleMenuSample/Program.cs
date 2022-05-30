namespace NetSamples.ConsoleMenuSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintBaseMenu();
            Console.WriteLine("Do you want continue? Y/N");
            var isContinue = Console.ReadLine().ToUpperInvariant() == "Y";

            if (isContinue)
            {
                PrintBaseMenu();
            }
        }


        static void PrintBaseMenu()
        {
            Console.WriteLine("Select option:");
            Console.WriteLine("1 - Base math operations");
            Console.WriteLine("2 - Extended options");
            Console.WriteLine("0 - Exit");


            var selectedBlock = Console.ReadLine();


            if (int.TryParse(selectedBlock, out var opt))
            {
                switch (opt)
                {
                    case 1:
                        PrintMathMenu();
                        break;
                    case 2:
                        PrintAdditionalMenu();
                        break;
                    case 0:
                        return;
                    default:
                        ProcessIncorrectInput();
                        break;
                }
            }
            else
            {
                ProcessIncorrectInput();
            }

           
        }

        static void PrintMathMenu()
        {
            Console.WriteLine("Select option:");
            Console.WriteLine("1 - X + Y");
            Console.WriteLine("2 - X - Y");
            Console.WriteLine("3 - X * Y");
            Console.WriteLine("4 - X / Y");
            Console.WriteLine("5 - X ^ 2"); //equivalent y=2
            Console.WriteLine("6 - X ^ Y");
            var selectedOperation = Console.ReadLine();
        }

        static void PrintAdditionalMenu()
        {
            Console.WriteLine("Select option:");
            Console.WriteLine("1 - Enter your name");
            Console.WriteLine("2 - Specify your age");
           
            var selectedOperation = Console.ReadLine();
        }

        static void ProcessIncorrectInput()
        {
            Console.WriteLine("Incorrect Input");
            PrintBaseMenu();
        }
    }
}