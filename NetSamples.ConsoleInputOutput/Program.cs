namespace NetSamples.ConsoleInputOutput 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello User");
            Console.WriteLine("Our program is designed for adding two numbers");
            
            Console.WriteLine("Please enter first number:");
            //var firstNumber = Convert.ToInt32(Console.ReadLine()); // if not int => exception
            //var firstNumber = int.Parse(Console.ReadLine()); // if not int => exception

            var firstNumber = 0.0;


            //var integer = 14;
            //var doubleVar = Convert.ToDouble(integer) + 0.5;
            //integer = Convert.ToInt32(doubleVar);
            //bool.TryParse("false", out bool isTrue);


            var isInt  = double.TryParse(Console.ReadLine(), out firstNumber);//if not int -> not exception

            Console.WriteLine("Please enter second number:");
            var secondNumber = Convert.ToInt32(Console.ReadLine()); 

            var sum = firstNumber + secondNumber;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
        }
    }
}