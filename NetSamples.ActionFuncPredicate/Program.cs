namespace NetSamples.ActionFuncPredicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoOperationWithAction(1,2, Add);


            Action<int, int> action = Add;
            action(1,2);

            Predicate<int> isPositive = i => i > 0;
            isPositive(5);

            Func<int, int> doubleNumber = DoubleNumber;
            var doubleResult = doubleNumber(2);

            int result = DoOperationWithFunc(2, DoubleNumber);
            Console.WriteLine(isPositive(2));
        }

        //Action - delegate void Action(0-16 parameters)
        //Predicate<T> - delegate bool Predicate(T t)
        //Func - delegate TResult Func<T1-T16, TResult>(T1-T16)


        static int DoOperationWithFunc(int x, Func<int, int> operation)
        {
            return operation(x);
        }

        static void DoOperationWithAction(int x, int y, Action<int, int> action)
        {
            action(x, y);
        }

        static int DoubleNumber(int n) => n * 2;

        static void Add(int x, int y) => Console.WriteLine(x + y);
    }
}