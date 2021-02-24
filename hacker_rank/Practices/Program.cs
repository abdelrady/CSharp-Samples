using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practices
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = 122;
            Console.WriteLine(string.Format("{0:d}", o));
            return;

            //var inputFilePath = Path.Combine(Environment.CurrentDirectory, "InputFiles");
            var inputFilePath = @"D:\VS_Projects\hacker_rank\Practices\InputFiles\";
            inputFilePath += "1.txt";
            var fileContent = File.ReadLines(inputFilePath).ToList();

            var length = int.Parse(fileContent[0]);
            var pairs = fileContent[1].Split(' ').Select(int.Parse).ToArray();
            var pairsCount = sockMerchant(length, pairs);
            Console.WriteLine(pairsCount);

            Console.ReadKey();
        }

        static int sockMerchant(int n, int[] ar)
        {
            var pairsCount = 0;
            var pairsDic = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (pairsDic.ContainsKey(ar[i]))
                {
                    pairsDic[ar[i]] += 1;
                    if (pairsDic[ar[i]] % 2 == 0) pairsCount++;
                }
                else pairsDic[ar[i]] = 1;
            }
            return pairsCount;
        }
    }
}
