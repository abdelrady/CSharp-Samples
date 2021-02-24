using System;
using System.Collections.Generic;
using System.IO;

namespace PairsDiff
{
    class Solution
    {

        // Complete the pairs function below.
        static int pairs(int k, int[] arr)
        {
            var count = 0;
            var hs = new HashSet<int>();
            foreach (var i in arr)
            {
                hs.Add(i);
            }

            Array.Sort(arr);
            foreach (var i in arr)
            {
                if (hs.Contains(i + k))
                {
                    count++;
                    hs.Remove(i);
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
            int result = pairs(k, arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
