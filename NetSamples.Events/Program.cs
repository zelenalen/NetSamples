namespace NetSamples.Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var society = new Society();

            var goodHuman = new Human();
            var badHuman = new Human();

            society.Add(goodHuman);
            society.Add(badHuman);

            for (int i = 0; i < 20; i++)
            {
                society.Humans[0].Do();
                society.Humans[1].Do();
            }
        }
    }
}