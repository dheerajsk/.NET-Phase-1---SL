using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lession2_Basics
{
    class FileProgram
    {
        public static void Do()
        {
            string dir = Directory.GetCurrentDirectory();
            string filePath = dir + "testData.txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine("File already exists");
            }
            else
            {
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.WriteLine("This is data 1");
                    writer.WriteLine("This is data 2");
                    writer.WriteLine("This is data 3");
                    writer.WriteLine("This is data 4");
                }
                Console.WriteLine("File is created and data is inserted");
            }

            Console.WriteLine("Reading file...");
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("Reading file text...");
            string text = File.ReadAllText(filePath);
            Console.WriteLine(text);

            File.Delete(filePath);
            Console.WriteLine("File deleted");

        }
    }
}
