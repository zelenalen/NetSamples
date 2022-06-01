namespace NetSamples.Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] intArray;

            var numbers = new int[10];//10 -length of array
            //all values in array = 0(default value)

            var numbers1 = new int[3] { 0,1,2 };

            var numbers2 = new int[] {1,2,3,4,5};
            
            var numbers3 = new [] { 1, 2, 3, 4, 5 };
            
            int[] numbers4 = { 1, 2 };

            string[] employees = { "Bob", "Tom", "Alice" };
            var lastElement = GetLastValueFromArray(employees);

            //indexes 

            Console.WriteLine(numbers3[2]); //3 -> explanation below
            // numbers3 => [1,2,3,4,5];
            //numbers3[0] - 1
            //numbers3[1] - 2
            //numbers3[2] - 3
            //numbers3[3] - 4
            //numbers3[4] - 5

            var firstElement = numbers3[0];

            numbers3[3] = 150;


            //fill array manually
            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Enter element[{i}]:");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //create array and fill it

            Console.WriteLine($"Enter length of array:");
            var length = Convert.ToInt32(Console.ReadLine());

            //var array = new int[length];

            //FillArray(ref array);

            var array = FillArrayManually(length);
        }

        //Bad practice but for sample
        static void FillArray(ref int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter element[{i}]:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //good practice
        static int[] FillArrayManually(int length)
        {
            var array = new int[length];

            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter element[{i}]:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            return array;
        }

        static string GetLastValueFromArray(string[] array)
        {
            var length = array.Length;
            return array[length];
        }


        static void CheckLengthSample()
        {
            var arr1 = new int[]{1,3,4};

            //arr1.Length = 115;

            arr1 = new int[115];

        }

        static int[] GenerateArray(int length)
        {
            var array = new int[length];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-1000, 1000);
            }

            return array;
        }

        static void SomeArraysWithRanks2Plus()
        {
            int[,] someArray;
            int[,] someArrays2 = { { 0, 1, 2 }, { 3, 4, 5 } };

            foreach (var i in someArrays2)
            {
                Console.WriteLine(i);
            }

            int[,,] arrayWithRank3= new int[2,3,4];
            int[,,,] arrayWithRank4= new int[2,3,4,5];
            int[,,,,] arrayWithRank5= new int[2,3,4,5,6];
        }
    }
}