namespace NetSamples.AnonymousMethodsAndLambda
{
    public delegate void PrintMessage(string message);
    public delegate void SomeOtherDelegate(string message, int x);
    public delegate int CalculateHandler(int x, int y);

    public delegate bool IsTrue(int x);


    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMessage(GetString(), delegate (string message)
            {
                message += "v1.0";
                Console.WriteLine(message);
            });

            WorkWithLambda();

            var list = new List<int>() { 1, 3, 4, 5, 6, 7, 12, 13, 11 };

            int result = Sum(list, i => i % 2 == 0);
            int result2 = Sum(list, i => i < 10 );


            var resultOfCalculate = Calculate();

            resultOfCalculate(1, 2);
        }

        static void ShowMessage(string message, PrintMessage handler)
        {
            handler(message);
        }

        static string GetString()  
            => "Hello World";


        static void LambdaExpressionSample()
        {
            //(parameters here) => Console.WriteLine("DO"); 

            PrintMessage printMessage = (string mes) => Console.WriteLine(mes);

            printMessage("x");

            SomeOtherDelegate sod =
                (str, x) =>
                {
                    var resultMessage = str + x;
                    Console.WriteLine(resultMessage);
                };

            sod("message-", 15);


            CalculateHandler sum = (x, y) => x + y;
            var result = sum(1,2);

            sum = (i, i1) =>
            {
                i++;
                i1++;

                var str = GetString();

                return i + i1;
            };

        }


        static void WorkWithLambda()
        {
            PrintMessage helloHandler = mes => Console.WriteLine(mes);
            PrintMessage helloHandler2 = mes => Console.WriteLine(mes);

            helloHandler += helloHandler2;

            helloHandler("hello world");
            
            helloHandler -= helloHandler2;

            helloHandler("hello world");
        }


        static int Sum(List<int> numbers, IsTrue func)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                if (func(number))
                {
                    sum += number;
                }
            }

            return sum;
        }


        static CalculateHandler Calculate()
        {
            var userInput = Console.ReadLine();

            if (userInput == "+")
            {
                return (x, y) => x + y;
            }

            return (x, y) => x - y;
        }
    }
}