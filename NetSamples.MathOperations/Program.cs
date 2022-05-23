using System.ComponentModel;

namespace NetSamples.MathOperations
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            // For comment -> Ctrl + K + C 
            // For uncomment -> Ctrl + K + U
            
            //+
            var x = int.MaxValue;
            var y = int.MaxValue;
            var z = (long)x + y;

            Console.WriteLine(z);

            //-
            x = 15;
            z = x - 10;
            Console.WriteLine(z);

            //*
            var a = 10000.5;
            var b = 51;
            var c = a*b;
            Console.WriteLine(c);
            
            // /
            x = 13;
            y = 4;
            z = x / y;
            Console.WriteLine(z);

            a = 13;
            b = 4;
            var result = b / a;
            c = a / b;
            Console.WriteLine(c);

            // %
            z = x % y;
            Console.WriteLine(z);

            //++ => +1
            //-- => -1

            var x1 = 5;
            var x2 = 5;
            var x3 = ++x1; //prefix 
            var x4 = x2++; //postfix

            Console.WriteLine(x1+x3);
            Console.WriteLine(x2+x4);

        }
    }
}