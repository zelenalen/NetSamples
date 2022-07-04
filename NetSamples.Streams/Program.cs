using System.IO.Compression;
using System.IO.IsolatedStorage;
using System.Text;

namespace NetSamples.Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var sdc = new SomeDisposableClass();
            //try
            //{
               
            //    sdc.OpenConnection();
            //    //todo implement some logic
            //}
            //finally
            //{
            //    //todo close connection to file
            //    sdc.Dispose();
            //}

            //try
            //{
            //    using (var dc = new SomeDisposableClass())
            //    {

            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}

            //var fsSample = new BinaryFileStreamSample();
            //fsSample.WorkWithFile(@"C:\Users\AlexiMinor\Desktop\New folder (2)\japanEmployees");

            var bigFilePath = @"D:\SomeTestDir\New Text Document (2).txt";

            //using (var sr = new StreamReader(bigFilePath,Encoding.UTF8))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }
            //}

            //var lines = File.ReadAllLines(bigFilePath);
            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            using (var memoryStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create,true))
                {
                    var demoFile = archive.CreateEntry("foo.txt");

                    using (var entryStream = demoFile.Open())
                    using (var streamWriter = new StreamWriter(entryStream))
                    {
                        streamWriter.Write("Bar!");
                    }
                }

                using (var fileStream = new FileStream(@"C:\Temp\test.zip", FileMode.Create))
                {
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    memoryStream.CopyTo(fileStream);
                }
            }

            var isoFile = IsolatedStorageFile.GetMachineStoreForApplication();
            isoFile.CreateFile("some.txt");

            isoFile.Close();
        }
    }
}