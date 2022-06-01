namespace NetSamples.ArrayOfArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];

            array[0] = new[] { 1, 2, 3, 4, 5 };
            array[1] = new[] { 1, 2, 3};
            array[2] = new[] { 1, 2, 3, 4, 5,6,78 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine($"{i}-{j} - {array[i][j]}");
                }
            }


            int[][][][] smth = new int[4][][][];

            for (int i = 0; i < smth.Length; i++)
            {
                var randValue = new Random().Next(2, 5);
                smth[i] = new int[randValue][][];

                for (int j = 0; j < smth[i].Length; j++)
                {
                    randValue = new Random().Next(2, 5);
                    smth[i][j] = new int[randValue][];

                    for (int k = 0; k < smth[i][j].Length; k++)
                    {
                        randValue = new Random().Next(2, 5);
                        smth[i][j][k] = new int[randValue];
                        
                        for (int l = 0; l < smth[i][j][k].Length; l++)
                        {
                            randValue = new Random().Next(0, 1000);
                            smth[i][j][k][l] = randValue;
                        }
                    }
                }
            }

            for (int i = 0; i < smth.Length; i++)
            {
                for (int j = 0; j < smth[i].Length; j++)
                {
                    for (int k = 0; k < smth[i][j].Length; k++)
                    {
                        for (int l = 0; l < smth[i][j][k].Length; l++)
                        {
                            Console.WriteLine(smth[i][j][k][l]);
                        }
                    }
                }
            }

            foreach (var array3 in smth)
            {
                foreach (var array2 in array3)
                {
                    foreach (var arr in array2)
                    {
                        foreach (var element in arr)
                        {
                            Console.WriteLine(element);
                        }
                    }
                }
            }
           
        }
    }
}