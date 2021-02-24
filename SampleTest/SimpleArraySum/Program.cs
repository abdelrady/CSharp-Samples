using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("D:\\inputs.txt");
            var size = int.Parse(lines[0]);
            var ar = lines[1].Split(' ').Select(int.Parse).ToArray();
            var result = simpleArraySum(ar);
            Console.WriteLine(result);
        }

        static int simpleArraySum(int[] ar)
        {
            var sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}
