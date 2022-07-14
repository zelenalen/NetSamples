namespace NetSamples.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DoSmth();

            SayHelloToSpecifiedUser();
            
            //request 2 numbers and sum them

            var arr = new[] { 1, 3, 4 };
            var arr2 = new[] { 1, 3, 4 };
            CalculateSum("",arr);

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

        static void SayHelloWorld(string user)
        {
            //some logic here
            Console.WriteLine($"Hello {user}");
            //some logic here
        }
        static void SayHelloToSpecifiedUser()
        {
            //var userName = GetUserName();
            var normalizedUserName = GetNormalizedString(GetUserName());

            SayHelloWorld(normalizedUserName);
        }
        static string GetUserName()
        {
            Console.WriteLine("Enter your name");
            var userName = Console.ReadLine();

            return userName;
        }
        static string GetNormalizedString(string str)
        {
            //var result = userName?.ToUpperInvariant() ?? "str";
            ////equivalent 
            //var z = userName?.ToUpperInvariant() != null 
            //    ? userName.ToUpperInvariant() 
            //    : "str";
            //equivalent 
            if (str == null)
            {
                return "str";
            }
            else
            {
                return str.ToUpperInvariant();
            }

            //a-> A
            //ab->AB
            //n->N
            //y->Y
            //vasyapupkin@GMAIL.COM -> VASYAPUPKIN@GMAIL.COM
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

        static void DoSmth()
        {
            bool isContinue = true;
            while (isContinue)
            {
                var userName = GetUserName();
                PrintInfoAboutUser(userName);

                isContinue = CheckIsContinue();
            }
        }

        static void PrintInfoAboutUser(string userName)
        {
            Console.WriteLine($"User - {userName}");
        }

        static bool CheckIsContinue()
        {
            Console.WriteLine("Do you want to continue: Y/N");
            var userInput = Console.ReadLine();

            var normalizedUserInput = GetNormalizedString(userInput);

            return normalizedUserInput == "Y";
        }

        static long CalculateSum(string str, params int[] numbers)
        {
            var sum = 0l;

            foreach (var i in numbers)
            {
                sum += i;
            }
            return sum;
        }

        static long CalculateSum(string str, int[] numbers, int[] numbers2, int[] numbers3, int[] numbers4)
        {
            var sum = 0l;

            foreach (var i in numbers)
            {
                sum += i;
            }
            return sum;
        }
    }
}