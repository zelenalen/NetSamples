namespace NetSamples.ConditionalOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 5;
            var y = 10;
            bool isEqual = x == y; //true or false
            Console.WriteLine(isEqual);

            var isNotEqual = x != y; //true or false
            Console.WriteLine(isNotEqual);

            //will return after classes explanation
            //var obj1 = new object();
            //obj1 = '2';
            //var obj2 = new object();
            //obj2 = 1;
            //obj2 = true;
            //isEqual = obj1 == obj2; 
            //Console.WriteLine(isEqual);

            var isGreater = x > y; //true or false
            var isLess = x < y; //true or false
            var isGreaterOrEqual = x >= y; //true or false
            var isLessOrEqual = x <= y; //true or false

            var tr = true;
            var fs = false;
            isGreater = Convert.ToInt32(tr) > Convert.ToInt32(fs); //1 or 0 -> true

            var a = "abca";
            var b = "bca";

            var result = a.CompareTo(b);
            //if less - (-1), if equal - 0, if greater - 1
            //if length of string is greater, then str also is greater
            //if length of string is equal, then str as collection of symbols(char) 



            //Logical operations in conditional operation
            
            //or - |
            var isTrue = (1 > 2) | (3 > 2); //false | true  -> true; 

            //and - & 
            isTrue = (1 > 2) & (3 > 2); //false & true  -> false;


            // OR - ||
            var isTrue1 = (1 > 2) || (3 > 2); //-> 2 calc
            var isTrue2 = (3 > 2) || (1 > 2);  // -> 1 calc
            
            var isTrue3 = (1 > 2) | (3 > 2); //-> 2 calc
            var isTrue4 = (3 > 2) | (1 > 2); //-> 2 calc



            //AND - &&
            isTrue1 = (1 < 2) && (3 > 2); //-> 2 calc
            isTrue2 = (1 > 2) && (3 > 2);  // -> 1 calc


            //!
            isTrue = !(5 > 6); //!false -> true, !true -> false


            //^ -> true if 1 or 2 operand is true, but not both at same time
            isTrue1 = (1 < 2) ^ (3 > 2);

        }
    }
}