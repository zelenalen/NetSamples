namespace NetSamples.BaseTypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //narrowing more bytes -> less bytes
            byte a = 4;//0-255

            byte b = (byte)(a + 253);
            //-> (as int 257) -  2byte 0000 0001 0000 0001 -> last 8(for byte) symbols
            // -> 0000 0001 -> 1
            Console.WriteLine(b);

            var x = 13000000l;
            var y = (int)x;


            //widening
            int x1 = int.MaxValue; //2kkk+
            int x2 = 1000; //2kkk+

            var result = x1 * x2;

            y = checked(x1 * x2);

            long y1 = x1; //

            var result = x1 * (long)x2;//2kkkk
            Console.WriteLine(result);


            //implicit conversion
            // if conversion is implicit & conversion is widening so

            // byte -> short -> int -> long -> decimal
            // int -> double
            // short -> float -> double
            // char -> int

            //explicit conversion

            int qwerty = 15;
            byte s = (byte)qwerty;

        }
    }
}