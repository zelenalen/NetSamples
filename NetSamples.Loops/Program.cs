namespace NetSamples.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for show multiplication table:");
            var userInput = Console.ReadLine();

            var number = 0;

            var isNumber = int.TryParse(userInput, out number);
            if (isNumber)
            {
                //Console.WriteLine($"{number}*1={number}");
                //Console.WriteLine($"{number}*2={number * 2}");
                //Console.WriteLine($"{number}*3={number * 3}");
                //Console.WriteLine($"{number}*4={number * 4}");
                //Console.WriteLine($"{number}*5={number * 5}");
                //Console.WriteLine($"{number}*6={number * 6}");
                //Console.WriteLine($"{number}*7={number * 7}");
                //Console.WriteLine($"{number}*8={number * 8}");
                //Console.WriteLine($"{number}*9={number * 9}");
                //Console.WriteLine($"{number}*10={number * 10}");

                for (var i = 0; i < 11; i++)
                {
                    Console.WriteLine($"{number}*{i}={number * i}");
                }

                for (double i = 0.0; i < 2; i += 0.1)
                {
                    Console.WriteLine($"{number}*{i}={number * i}");
                }
            }

            userInput = Console.ReadLine();

            var iterationAmount = 0;

            isNumber = int.TryParse(userInput, out iterationAmount);

            if (isNumber)
            {
                for (int i = 0; i < iterationAmount; i++)
                {
                    if (i % 13 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        if (i % 5 == 0)
                        {
                            i *= 10;
                        }
                    }

                }
            }

            //for with opt part
            for (; isNumber;) //potentially infinite loop
            {
                userInput = Console.ReadLine();
                var x = 0;
                isNumber = int.TryParse(userInput, out x);
                Console.WriteLine(x);
            }


            //do while
            var zx = 15;

            //do
            //{
            //    zx--;
            //    Console.WriteLine(zx);
            //} while (zx<=0);


            //zx = 15;
            //while (zx <= 0)
            //{
            //    zx--;
            //    Console.WriteLine(zx);
            //}

            //infinite loop
            //while (true)
            //{
            //    var x1 = 0;
            //}

            var j = 0;
            for (int i = 0; i < 20000; i++)
            {
                if (i%138==0)
                {
                    j++;
                }

                if (j>=100)
                {
                    Console.WriteLine("we got break here");
                   break; 
                }
            }

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }

                if (i%5==0)
                {
                    Console.WriteLine(i);
                }
            }


            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    Console.WriteLine($"{i}-{k}"); //0-0, 99-99
                }
            }
        }
    }
}