using System;
using System.IO;
using System.Linq;

namespace LinesCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter File Path:");
            var filePath = Console.ReadLine();
            Console.WriteLine(File.ReadLines(filePath).Count());
        }
    }
}
