namespace NetSamples.Variables
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("It's nice day today!");

            Console.WriteLine("Enter anything to continue:");

            const string CONST_VARIABLE = "Bla bla bla";

            string userInput; 
            userInput = Console.ReadLine();

            int value = 15; //initialization

            Console.WriteLine("Your input:");
            Console.WriteLine(userInput);

            Console.WriteLine("Enter anything else to continue:");
            userInput = Console.ReadLine();

            Console.WriteLine("Your 2nd input:");
            Console.WriteLine(userInput);

            Console.WriteLine(value);
            Console.WriteLine(CONST_VARIABLE);

            Console.WriteLine(true);

            Console.WriteLine("GoodBye, see you soon");
        }
    }
}