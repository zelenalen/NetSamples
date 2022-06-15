namespace NetSamples.Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            var handler = new Handler();
            
            DoSmth(worker);
            handler.DoSmth();
            DoSmth(handler);

            var obj1 = new SomeComparableType(){A = 2};
            var obj2 = new SomeComparableType(){A = 5};

            var compareResult = obj1.CompareTo(obj2);

        }

        public static void DoSmth(ICanDoSmth smth)
        {
            smth.DoSmth();
        }


    }
}