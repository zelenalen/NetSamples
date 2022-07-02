namespace NetSamples.Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str1 = "hello";

            var str2 = new string('a', 15); //aaa - 15
            var str3 = new string(new char[]{'h','e','l','l','o'});
            var str4 = new string(new char[] { 'h', 'e', 'l', 'l', 'o' }, 2,2);

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);

            var firstSymbol = str1[0];

            for (int i = 0; i < str1.Length; i++)
            {
                Console.WriteLine(str1[i]);
            }

            foreach (var symbol in str1)
            {
                Console.WriteLine(symbol);
            }

         
            var x1 = "hello";
            var y1 = "hello";

            Console.WriteLine(x1 == y1);

            //immutable
            var worldStr = " world";

            str1 += worldStr; //=>"hello world"

            var sw = new StringWorker();
            sw.SplitString();
            sw.TrimString();
            sw.FormatString();
        }
    }
}