using System;
using System.Collections.Generic;
//using System.Collections.Generic;
using System.Linq;

class Solution
{

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {
        long sum = 0;
        //1 2 5 3 7 8 6 4
        //1 2 3 4 5 8 7 6
        for (int i = q.Length - 1; i >= 0; i--)
        {
            int moves = q[i] - (i + 1);
            if (moves > 2)
            {
                Console.WriteLine("Too chaotic");
                return;
            }
            for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                if (q[j] > q[i]) sum++;
        }
        Console.WriteLine(sum);
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
