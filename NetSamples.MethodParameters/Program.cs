namespace NetSamples.MethodParameters 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 13;

            Console.WriteLine($"Main before Increment Method: n = {number}"); //13
            Increment(number); 
            Console.WriteLine($"Main after Increment Method: n = {number}"); // 13

            Console.WriteLine($"Main before Decrement Method: n = {number}"); //13
            Decrement(ref number); //12
            Console.WriteLine($"Main after Decrement Method: n = {number}"); // 12\

            int sum;
            Sum(5,10, out sum);

            Console.WriteLine(sum);//15

            var someValue = int.TryParse(Console.ReadLine(), out var x);//out var x equivalent below
            //int x;
            // , out x)

            x = 15;

            var a = 1;
            var b = 2;
            var c = 3;
            CalculateTrianglePerimeter(a,b,c);//while run in multi-thread


            Decrement(ref c);
        }

        static void Increment(int n)// int n = number;
        {
            n++;
            Console.WriteLine($"Increment Method: n = {n}"); //14
        }
        
        static void Decrement(ref int n) //reference 
        {
            n--;
            Console.WriteLine($"Decrement Method: n = {n}"); //12
        }

        static void Sum(int x, int y, out int result)
        {
           var z = x + y;
           result = z;
        }


        static void CalculateTrianglePerimeter(in int a, in int b, in int c)
        {
            for (int i = 0; i < 1000000; i++)
            {
                var perimeter = a + b + c;
            }
        }

    }
}