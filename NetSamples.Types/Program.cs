namespace NetSamples.Types
{
    public class Program
    {
        static void Main(string[] args)
        {
            //VALUABLE TYPES 

            //bool (Boolean) -> 1 bit
            bool alive = true; //1
            bool isDead = false; //0

            //byte - 1byte -> 0-255
            byte byte1 = 1;
            byte byte2 = 255;

            //sbyte -> 1byte -> -128-127
            sbyte sb1 = 1;
            sbyte sb2 = 127;

            //short - 2byte -> 65,536 variants (-32,768 - 32,767)
            short s1 = -32768;
            short s2 = 32767;

            //ushort - 2byte -> 65,536 variants (0 - 65,536)
            ushort us1 = 0;
            ushort us2 = 65535;

            //int & uint -> 4 byte -> 2^32 variants
            int i = 150000000;
            uint ui = 4294967295;

            //long & ulong -> 8 byte -> (-9 223 372 036 854 755 808 - 9 223 372 036 854 755 807)
            long l = 150000000;
            long ul = 4294967295;

            //float -> 4byte -> -3.4*10^38 -> 3.4*10^38
            float fl = 10.15f;
            //double -> 8byte -> +-5*10^-324 - 1.7*10^308
            double d = 10.15;

            //decimal -> 16byte -> +-1*10^-28 - 7.9228*10^28
            decimal dec = 10.15m;

            //char -> 2byte -> unicode-symbol
            char character1 = 'a';
            char character2 = '\x5A'; //-> asci table hex symbol
            char character3 = '\u04EE'; //unicode symbol

            Console.WriteLine(character1);
            Console.WriteLine(character2);
            Console.WriteLine(character3);

            //up to 2GB - ? 
            string str = "str";


            //OBJECT
            object obj = 'a';

            var varCustomType = true;
            var characterC = 'C';
        }
    }


  
}