namespace NetSamples.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("123");

            SayHelloWorld();

            //request 2 numbers and sum them
            
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            
            Sum2Values(a,b);
            Sum2Values(2,5);
            Sum2Values(a,1);


            var trianglePerimeter = CalculatePerimeter(1,2,3);
            CalculatePerimeter(z:1,x:2,y:3);

            Console.WriteLine($"Triangle perimeter = {trianglePerimeter}");

            PrintEmployeeInfo("Bob",30,"Apple");
            PrintEmployeeInfo("Alice",20);


            PrintCompanyInfo(headOffice: "Seattle", name: "Apple");
        }

        static void SayHelloWorld()
        {
            //some logic here
            Console.WriteLine("Hello World");
            //some logic here
            return;
        }

        static int CalculatePerimeter(int x)//for square
        {
            return x * 4;
        }
        static int CalculatePerimeter(int x, int y) //rectangle
        {
            var perimeter = x * 2 + y * 2;
            return perimeter;
        }
        static int CalculatePerimeter(int x, int y, int z) //triangle
        {
            return x + y + z;
        }

        static void Sum2Values(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
       
        static void PrintEmployeeInfo(string name,
            int age, 
            string company = "Microsoft")
        {

            Console.WriteLine($"{name} - {age} - {company}");
        }

        static void PrintCompanyInfo(string name="MS",
          int employeeAmount=100000,
          string headOffice="Redmond")
        {
            Console.WriteLine($"{name} - {employeeAmount} - {headOffice}");
        }
    }
}