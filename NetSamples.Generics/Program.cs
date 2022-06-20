namespace NetSamples.Generics // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var billy = new User<int, string>(1, "billy");
            var bob = new User<string, string>("2a", "bob");

            User<int, string>.X = 15;
            User<string, string>.X = 16;

            User<int, string>.Y = 15;
            User<string, string>.Y = "16";

            Console.WriteLine($"uix - {User<int,string>.X} \nuiy - {User<int, string>.Y}\nusx - {User<string, string>.X} \nuiy - {User<string, string>.Y}");

            var euRegionalOffice = new RegionalOffice<User<int, string>>(billy);
        }

        static void Swap<T>(ref T x, ref T y) //=> y =x, x = y
        {
            var temp = x;
            x = y;
            y = temp;
        }

        static void Do<T, TY>(T t, TY ty)
            where T : class
            where TY : class
        {

        }

        //public static User GetUserById(User[] users, int id)
        //{
        //    //foreach (var user in users)
        //    //{
        //    //    if (user.Id == id)
        //    //    {
        //    //        return user;
        //    //    }
        //    //}

        //    //return null;
        //}
    }
}