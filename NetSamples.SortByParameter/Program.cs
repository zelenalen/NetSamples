namespace NetSamples.SortByParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<SomeClass>
            {
                new() { A = 1, B = 2 },
                new() { A = 2, B = 3 },
                new() {A = 7, B = 12},
                new() {A = 1, B = 162}
            };

            //sorted by default
            list.Sort();
            foreach (var someClass in list)
            {
                Console.WriteLine($"{someClass.A} - {someClass.B}");
            }

            list.Sort(new SomeClassBComparer());
            foreach (var someClass in list)
            {
                Console.WriteLine($"{someClass.A} - {someClass.B}");
            }

            list.Sort(new SomeClassAComparer());
            foreach (var someClass in list)
            {
                Console.WriteLine($"{someClass.A} - {someClass.B}");
            }
        }
    }
}