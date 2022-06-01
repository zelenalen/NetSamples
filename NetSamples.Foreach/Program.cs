namespace NetSamples.Foreach
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var numbers2 = new[] { 1, 2, 3, 4, 5 };

            for (int k = 0; k < numbers.Length; k++)
            {
                numbers2[k] = numbers[k]*2;
            }

            int i =0;
            foreach (var number in numbers)
            {
                i++;
                if (number == 15)
                {
                    numbers2[i] = 25;
                }
                Console.WriteLine(number);
            }

            Console.WriteLine(numbers[1]);
        }
    }
}