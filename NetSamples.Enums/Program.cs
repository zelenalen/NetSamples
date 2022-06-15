using System.Diagnostics;

namespace NetSamples.Enums
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var operation = CalculatorOperations.Subtraction;
            //var intOperation = (int)operation;

            //var input = Console.ReadLine();

            //var smth = Enum.TryParse(typeof(CalculatorOperations), input
            //    ,out var someOtherOperation);


            if (Enum.IsDefined(typeof(CalculatorOperations), 18))
            {
                var someOp = (CalculatorOperations)18;
                Console.WriteLine(someOp);
            }
            else
            {
                Console.WriteLine("That enum doesn't exist");
            }

            //Console.WriteLine(operation);
            //Console.WriteLine(intOperation);


            //switch (operation)
            //{
            //    case CalculatorOperations.Sum:
            //        break;
            //    case CalculatorOperations.Divide:
            //        break;
            //    case CalculatorOperations.Factorial:
            //        break;
            //    case CalculatorOperations.Multiply:
            //        break;
            //    case CalculatorOperations.Subtraction:
            //        break;
            //}

            var thursday = DaysOfWeek.Thursday;
            Console.WriteLine(thursday);
            Console.WriteLine((int)thursday);
            var sunday = DaysOfWeek.Sunday;
            Console.WriteLine(sunday);
            Console.WriteLine((int)sunday);
        }
    }
}