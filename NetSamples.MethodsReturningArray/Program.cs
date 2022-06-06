namespace NetSamples.MethodsReturningArray 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = GetNumbers();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            var charArray = GetSymbols();

            var str = new string(charArray);
            Console.WriteLine(str);
        }

        static int[] GetNumbers()
        {
            if (true)
            {
                return null;
            }
            return new[] { 1, 2, 3 };
        }

        static char[] GetSymbols()
        {
            return new[] { 'a','b','c','d','e' };
        }

        static void Do()
        {
            var numbers = GetNumbers();

            //var numbersLength = numbers?.Length ?? 0;


            var arrayLength = numbers?.Length;

            var x = GetNumbers() ?? new []{15,16};

            //equivalent below
            //int? length;
            //if (numbers != null )
            //{
            //    length = numbers.Length;
            //}
            //else
            //{
            //    length = null;
            //}

            //if (length == null)
            //{
            //    length = 0;
            //}

            string? nullableStr = null;

            var str = Console.ReadLine();

            var result = Math.Pow(15, 2.5);
        }
    }
}