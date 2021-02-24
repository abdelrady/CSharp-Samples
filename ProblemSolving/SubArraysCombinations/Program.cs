using System;
using System.Collections.Generic;
using System.IO;

namespace SubArraysCombinations
{
    class Program
    {
        // https://www.hackerrank.com/challenges/maximum-subarray-sum/forum/comments/567659?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=search
        // https://www.youtube.com/watch?v=u_ft5jCDZXk&feature=youtu.be
        static long maximumSum(long[] a, long m)
        {
            long max = 0;
            //printSubArraysRec(a, 0, 0, m, ref max);
            //printSubArrays(a, m, ref max);
            long[] prefix = new long[a.Length];
            long curr = 0;
            for (int i = 0; i < a.Length; i++)
            {
                curr = (a[i] % m + curr) % m;
                prefix[i] = curr;
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if(prefix[j] > prefix[i]) max = Math.Max(max, (prefix[i] - prefix[j] + m) % m);
                }
                max = Math.Max(max, prefix[i]); // Don't forget sum from beginning. 
            }

            return max;
        }

        static void printSubArrays(long[] arrA, long m, ref long max)
        {

            int arrSize = arrA.Length;
            //start point
            for (int startPoint = 0; startPoint < arrSize; startPoint++)
            {
                //group sizes
                for (int grps = startPoint; grps <= arrSize; grps++)
                {
                    long sum = 0;
                    //if start point = 1 then
                    //grp size = 1 , print 1
                    //grp size = 2, print 1 2
                    //grp size = 3, print 1 2 3 ans so on
                    for (int j = startPoint; j < grps; j++)
                    {
                        sum += arrA[j];
                    }
                    var mod = sum % m;
                    max = Math.Max(max, mod);
                }
            }
        }

        static void printSubArraysRec(long[] arr,
            int start, int end, long m, ref long max)
        {
            // Stop if we have reached  
            // the end of the array  
            if (end == arr.Length)
                return;

            // Increment the end point  
            // and start from 0  
            else if (start > end)
                printSubArraysRec(arr, 0, end + 1, m, ref max);

            // Print the subarray and  
            // increment the starting point  
            else
            {
                long sum = 0;
                for (int i = start; i < end; i++)
                {
                    sum += arr[i];
                }
                sum += arr[end];
                var mod = sum % m;
                max = Math.Max(max, mod);
                printSubArraysRec(arr, start + 1, end, m, ref max);
            }
            return;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] nm = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nm[0]);

                long m = Convert.ToInt64(nm[1]);

                long[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt64(aTemp))
                    ;
                long result = maximumSum(a, m);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }

    }
}
