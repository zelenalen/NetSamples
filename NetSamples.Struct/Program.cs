using System.Diagnostics;

namespace NetSamples.Struct
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Cat cat;
            //cat.Age = 10;
            //cat.Name = "Cat";
            //cat.AmountOfLives = 3;

            //cat.PrintInfo();

            ////if you need to copy one structure to another with some changes
            //Cat cat2 = cat with {Name = "NonCat", Age = 8};

            Console.ReadLine();

            var tiger = new Tiger();
            var x = tiger.AmountOfLives;

            var sw = new Stopwatch();
            sw.Start();
            var tiger1 = new Tiger();
            var x1 = tiger1.AmountOfLives;
            Console.WriteLine(x1);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);

            sw.Restart();
            var cat = new Cat();
            var z = cat.AmountOfLives;
            Console.WriteLine(z);

            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);


        }
    }
}