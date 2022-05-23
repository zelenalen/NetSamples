namespace NetSamples.LogicalOperation 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // &
            var x = 2; //010
            var y = 5; //101
            var result = x & y; // 010 & 101 -> 000 -> 0
            Console.WriteLine(result); //-> 0
            
            x = 4; //100
            result = x & y; // 100 & 101 -> 100 -> 4
            Console.WriteLine(result); //-> 4

            //ctrl+r ctrl+r - rename

            // |
            x = 2; //010
            y = 5; //101
            result = x | y; // 010 | 101 -> 111 -> 7
            Console.WriteLine(result); //-> 7

            x = 4; //100
            result = x | y; // 100 & 101 -> 101 -> 5
            Console.WriteLine(result); //-> 5

            // ^ - XOR
            //if value is dif - 1, else - 0;
            x = 17; //10001 
            var key = 100; //110 \0100

            var encryptedValue = x ^ key; 
            // 001 0001 
            // 110 0100
            // 111 0101
            Console.WriteLine(encryptedValue);

            var decryptedValue = encryptedValue ^ key;
            // 111 0101
            // 110 0100
            // 001 0001
            Console.WriteLine(decryptedValue);

            // ~ - inversion
            x = 7;  // 0000 0111
            y = ~x; // 1111 1000
            Console.WriteLine(y); //-8

            //x = 4; // 0000 0100
            //y = 1; 
            //result = x<<y; // 0000 1000 -> 8

            x = 7; // 0000 0111
            y = 31;
            result = x << y; // 0110 0000 
            Console.WriteLine(result);

            x = 16; // 100
            y = 2;
            result = x>>y; //4

            Console.WriteLine(result);



        }
    }
}