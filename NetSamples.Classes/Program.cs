namespace NetSamples.Classes 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person(35, true, "Bob",2)
            {
                IsAlive = false
            };

            var pName = bob.Name;

            bob.PrintInfo();
            var bobInfo = bob.GetInfo();

            bob.Age = 45;

            var alice = new Person()
            {
                Age = 27,
                IsAlive = true,
                Name = "Alice", 
            };

            //alice.Age = 27;
            //alice.IsAlive = true;

            Console.WriteLine($"Bob is human - {Person.IS_HUMAN}");

            var smth = new SomeClass();

            var vasily = new Cat("Vasily", "Grey", 3, 9);

            var murka = new Cat("Murka", 3);


            var bobik = new Dog("Shepard")
            {
                Name = "Bobik",
                Age = 1
            };

            bobik.Age++;
            bobik.Age++;
            bobik.Age++;

            bobik.Name = "Muhtar";

            //var bobikRace = bobik.Race;

            bobik.Race = "Terrier";

            bobik.PrintInfo();
        }
    }
}