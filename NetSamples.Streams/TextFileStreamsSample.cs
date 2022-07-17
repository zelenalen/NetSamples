using System.Text;

namespace NetSamples.Streams;

public class TextFileStreamsSample
{
    public void WorkWithFile(string filePath)
    {
        using (var sw = new StreamWriter(filePath, true, Encoding.UTF8))
        {
            sw.Write($"some Text{Environment.NewLine}");
            sw.WriteLine($"some {Environment.NewLine}Text 2");
        }
        using (var sw = new StreamReader(filePath, Encoding.UTF8))
        {
            //var symbol = sw.Peek();//-return next available symbol or -1(if file ends)

            //var content = sw.Read();//-return next available symbol
            //var buffer = new char[15];
            //var content2 = sw.Read(buffer, 0, 15);//-return next available symbol

            var firstLine = sw.ReadLine();
            var allContent = sw.ReadToEnd();
        }
        //read all text line by line
        using (var sw = new StreamReader(filePath, Encoding.UTF8))
        {
            while (!sw.EndOfStream)
            {
                var line = sw.ReadLine();
                Console.WriteLine(line);
            }
        }

        using (var sw = new StreamReader(filePath, Encoding.UTF8))
        {
            var allText = sw.ReadToEnd();
        }
    }
}