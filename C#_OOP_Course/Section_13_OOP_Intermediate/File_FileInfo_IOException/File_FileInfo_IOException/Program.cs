using System;
using System.IO;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\file.txt";
            string targetPath = @"C:\temp\file_copy.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}