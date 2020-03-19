using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Thomas Shetler\Documents\HTML\C-Sharp-Projects\FileIO\FileIO\NewFolder1\log.txt";
            Console.WriteLine("Write a number!");
            string text = Console.ReadLine();
            //File.WriteAllText(path, text);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Thomas Shetler\Documents\HTML\C-Sharp-Projects\FileIO\FileIO\NewFolder1\log.txt", true))
            {
                file.WriteLine(text);
            }
            string readss = File.ReadAllText(@"C:\Users\Thomas Shetler\Documents\HTML\C-Sharp-Projects\FileIO\FileIO\NewFolder1\log.txt");
            Console.WriteLine(readss);
            
        }
    }
}
