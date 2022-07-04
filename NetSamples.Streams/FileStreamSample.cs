using System.Globalization;
using System.Text;

namespace NetSamples.Streams;

public class FileStreamSample
{
    public void WorkWithFile(string filePath)
    {

        using (var fs = new FileStream (filePath, FileMode.OpenOrCreate))
        {
            var buffer = new byte[256];

            //var amountOfReadingBytes =fs.Read(buffer, 0, (int)fs.Length);
            using (var newFS = new FileStream(@"C:\Users\AlexiMinor\Desktop\New folder (2)\161gb.txt", FileMode.OpenOrCreate))
            {
                fs.CopyTo(newFS);    
                var amountOfReadingBytes =fs.Read(buffer, 0, (int)fs.Length);
                newFS.Flush(true);

            }
            fs.Seek(0,SeekOrigin.Begin);//for move pointer

            var newContent = new byte[10]
            {
                65,
                66,
                67,
                68,
                69,
                70,
                71,
                72,
                73,
                74,
            };

            fs.Write(newContent, 0, newContent.Length);
        }
        
        using (var fs = File.Open(filePath, FileMode.OpenOrCreate))
        {

        }

        using (var fs = File.OpenRead(filePath))
        {

        }

        using (var fs = File.OpenWrite(filePath))
        {

        }

    }

    public void ReadByteByByte(string filePath)
    {
        using (var fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            Console.WriteLine(fs.Name);
            Console.WriteLine($"Position {fs.Position}");
            Console.WriteLine(fs.Length);

            Console.WriteLine("Trying to read");
            var intValue = fs.ReadByte();
            var firstSymbol = Encoding.UTF8
                .GetString(new[] { (byte)intValue });
            Console.WriteLine($"Position {fs.Position}");
            Console.WriteLine(intValue);
            Console.WriteLine(firstSymbol);

            intValue = fs.ReadByte();
            var secondSymbol = Encoding.UTF8
                .GetString(new[] { (byte)intValue });
            Console.WriteLine($"Position {fs.Position}");
            Console.WriteLine(intValue);
            Console.WriteLine(secondSymbol);

            intValue = fs.ReadByte();
            var thirdSymbol = Encoding.UTF8
                .GetString(new[] { (byte)intValue });
            Console.WriteLine($"Position {fs.Position}");
            Console.WriteLine(intValue);
            Console.WriteLine(thirdSymbol);

            intValue = fs.ReadByte();
            var forthSymbol = Encoding.UTF8
                .GetString(new[] { (byte)intValue });
            Console.WriteLine($"Position {fs.Position}");
            Console.WriteLine(intValue);
            Console.WriteLine(forthSymbol);
        }
    }
}