using System.Text;

namespace NetSamples.NewLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var messageText = "Hello";
            PrintMessage(messageText);
            
            messageText = "World";
            PrintMessage(messageText);

            Print2LinesWithN();
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void Print2LinesWithN()
        {
            Console.WriteLine("Hello \nWorld");
        }

        static void Print2LinesWithEnv()
        {
            Console.WriteLine($"Hello {Environment.NewLine}World"); // \n
        }
    }
}