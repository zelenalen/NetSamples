using System.Security.Cryptography.X509Certificates;

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


            var company = new Company();
            company.employees = new Employee[]
            {
                //new Employee(),
                //new Employee(),
                //new Employee(),
                //new Employee()
            };

            Console.Clear();

            var st1 = new Store(1, "Some address");
            var st2 = new Store(1, "Some address");

            //var stores = new Store[]
            //{
            //    new Store()
            //    {
            //        Id = 1,
            //        Address = "Some Address 1"
            //    },
            //    new Store()
            //    {
            //        Id = 2,
            //        Address = "Some Address 2"
            //    },
            //    new Store()
            //    {
            //        Id = 2,
            //        Address = "Some Address 3" 
            //    }
            //};
            Store.StoreNetworkName = "Hogs and hooves";

            //Store.Discount = 15;

            var price = Store.CalculatePrice(100);
            Store.CreateRoute(15,18);


        }
    }
}