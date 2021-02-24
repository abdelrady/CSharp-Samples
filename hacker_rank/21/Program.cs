using System;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = MaxContiguousSubsequence(new int[] { 5, 15, -30, 10, -5, 40, 10});
            Console.WriteLine(res);
        }

        private static int MaxContiguousSubsequence(int[] a)
        {
            var s = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                s[i] = a[i] + Math.Max(0, i == 0 ? 0 : s[i - 1]);
            }

            var max = s[0];

            for (int i = 0; i < s.Length; i++)
            {
                if (max < s[i])
                    max = s[i];
            }

            return max;
        }
    }
}
