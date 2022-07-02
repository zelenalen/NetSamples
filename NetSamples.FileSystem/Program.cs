using System;
using System.Collections.Generic;
using System.IO;

namespace NetSamples.FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var drives = DriveInfo.GetDrives();
            Console.WriteLine("Drives:");
            foreach (var driveInfo in drives)
            {
                Console.WriteLine(driveInfo.Name);
                Console.WriteLine(driveInfo.DriveFormat);
                if (driveInfo.IsReady)
                {
                    Console.WriteLine(driveInfo.TotalSize);
                    Console.WriteLine(driveInfo.TotalFreeSpace);
                    Console.WriteLine(driveInfo.VolumeLabel);
                }
            }
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Directories:");

            var dDirectories = Directory.GetDirectories(@"D:\");

            foreach (var directory in dDirectories)
            {
                Console.WriteLine(directory);
            }
            Console.WriteLine("_____________");
            if (!Directory.Exists(@"D:\SomeTestDir"))
            {
                Directory.CreateDirectory(@"D:\SomeTestDir");

            }

            dDirectories = Directory.GetDirectories(@"D:\", "bckp*");
            foreach (var directory in dDirectories)
            {
                Console.WriteLine(directory);
            }
            //Directory.Delete(@"D:\SomeTestDir", true);
            var currentDir = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDir);

            var dirInfo = new DirectoryInfo(@"D:\SomeTestDir");


            var files = dirInfo.GetFiles();

            var testFilePath = @"D:\SomeTestDir\New Text Document (2).txt";

            //.Append - appends
            //write - create * override 
            //File.WriteAllText(testFilePath,
            //    "When you picture mountain climbers scaling Mount Everest, what probably comes to mind are teams of climbers with Sherpa guides leading them to the summit, equipped with oxygen masks, supplies and tents.And in most cases you'd be right, as 97 per cent of climbers use oxygen to ascend to Everest's summit at 8, 850 metres above sea level.The thin air at high altitudes makes most people breathless at 3, 500 metres, and the vast majority of climbers use oxygen past 7, 000 metres.A typical climbing group will have 8–15 people in it, with an almost equal number of guides, and they'll spend weeks to get to the top after reaching Base Camp.");

            var text = File.ReadAllText(testFilePath);
            Console.Write(text[0]);
            
            var catsFilePath = @"Cats.txt";
            var catsStringRepresentation = File.ReadAllLines(catsFilePath);
            var cats = new List<Cat>();

            foreach (var s in catsStringRepresentation)
            {
                var data = s.Split("-");
                var cat = new Cat(data[0], data[1]);
                cats.Add(cat);
            }

            foreach (var cat in cats)
            {
                Console.WriteLine($"Cat {cat.Name} - color-{cat.Color}");
            }
        }   
    }
}
