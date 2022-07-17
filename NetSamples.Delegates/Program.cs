namespace NetSamples.Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMessage printMessage;

            printMessage = HelloPrinter.PrintHelloWorld; 
            printMessage += PrintHowAreYou;
            printMessage += HelloPrinter.PrintHelloWorld;       
            printMessage += PrintHowAreYou;
            printMessage += HelloPrinter.PrintHelloWorld;


            printMessage(); //5 rows here

            printMessage -= HelloPrinter.PrintHelloWorld;
            printMessage -= HelloPrinter.PrintHelloWorld;
            printMessage -= HelloPrinter.PrintHelloWorld;
            printMessage -= HelloPrinter.PrintHelloWorld;

            if (printMessage != null) 
                printMessage(); 

            var list = new List<int>() {1,2,3,4};
            var isSuccess = list.Remove(5);


            PrintMessage printHowAreYou = PrintHowAreYou;

            PrintMessage printAll = printMessage + printHowAreYou;
            printAll();

            CalculatePrice calculatePrice;

            calculatePrice = Plane.CalculateFlightCost;
            calculatePrice += Train.CalculateTripCost;

            var result = calculatePrice(1000); //execute both methods,
                                               //but return value only from last one

            var result2 = calculatePrice?.Invoke(1000); //full equivalent of row 40

            SomeGenericMethod<int, double> genericMethod = Do;

            var res = genericMethod(0.0);

            var userOperationInput = Console.ReadLine();
            var operation = GetOperation(userOperationInput);

            operation(1, 2);
        }

        static void BaseSample()
        {
            HelloPrinter.PrintHelloWorld(); //if static

            var welcomePrinter = new WelcomeMessagePrinter();
            welcomePrinter.Print(); //if non static

            PrintMessage printMessage1;
            PrintMessage printMessage2;

            printMessage1 = HelloPrinter.PrintHelloWorld;
            printMessage2 = welcomePrinter.Print;

            welcomePrinter.MessageText = "Blablabla";

            //some code here

            printMessage1();
            printMessage2();

            var distance = 1500;
            CalculatePrice calculatePrice = null;

            Console.WriteLine("1/2");

            var x = Convert.ToInt32(Console.ReadLine());

            var cost = 0.0m;
            switch (x)
            {
                case 1:
                    calculatePrice = Plane.CalculateFlightCost;
                    break;
                case 2:
                    calculatePrice = Train.CalculateTripCost;
                    break;
                default:
                    break;
            }

            if (calculatePrice != null)
            {
                var price = CalculateCostByDistance(distance, calculatePrice);
                Console.WriteLine(price);
            }
        }

        static decimal CalculateCostByDistance(int distance, CalculatePrice calculatePrice)
        {
            return calculatePrice(distance);
        }


        static void PrintHowAreYou()
        {
            Console.WriteLine("How are you?");
        }

        static int Do(double x)
        {
            return 0;
        }

        static MathOperation GetOperation(string operation)
        {
            switch (operation)
            {
                case "+":
                    return Calculator.Sum;
                case "-":
                    break;
                case "*":
                    break;
                case "/":
                    break;
            }

            return null;

        }
    }

}