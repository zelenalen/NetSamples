namespace NetSamples.IfElseSample 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            
            var userInput = Console.ReadLine();
            double number;
            
            bool isNumber = double.TryParse(userInput, out number); //true or false

            var x = 0;


            if (isNumber) 
            {
                Console.WriteLine($"Your number: {number}");
                x = 10;
                Console.WriteLine($"x = {number}");
            }
            else
            {
                Console.WriteLine("Not a number");
            }

            var a = 10;
            var b = 15;
            var c = 5;
            var d = 25;
            
            if (a == b)
            {
                Console.WriteLine("a = b");
            } 
            else if (a == c)
            {
                Console.WriteLine("a = c");
            }
            else if (b == c)
            {
                Console.WriteLine("c = b");
            }
            else if (d == a)
            {
                Console.WriteLine("a = d");
            }
            else
            {
                Console.WriteLine("a,b,c,d");
            }

            if (a>=b && a>=c && a>=d)
            {
                Console.WriteLine($"{a} is the biggest one");
            }
            else if (b >= c && b >= d)
            {
                Console.WriteLine($"{b} is the biggest one");
            } 
            else if (c >= d)
            {
                Console.WriteLine($"{c} is the biggest one");
            }
            else
            {
                Console.WriteLine($"{d} is the biggest one");
            }


            if ((1>2 || 5>3) && 4<5)
            {
                
            }
            
            var userInput2 = Console.ReadLine();
            double number2=0.0;

            //Ternar operations - equivalent below
            var z = double.TryParse(userInput2, out number2) 
                ? number2 
                : 0;

            var zx = 0.0;
            if (double.TryParse(userInput2, out number2))
            {
                zx = number2;
            }
            else
            {
                zx = 0;
            }

            Console.WriteLine("End of program");
        }
    }
}