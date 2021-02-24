using System;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = LIS(new[] { 5, 7, 4, -3, 9, 1, 10, 4, 5, 8, 9, 3 });
            Console.WriteLine(res);
        }

        private static int LIS(int[] a)
        {
            var l = new int[a.Length];

            for (int i = 1; i < a.Length; i++)
            {
                l[i] = 1;
                for (int j = 1; j <= i - 1; j++)
                {
                    if (a[j] < a[i] && l[i] < 1 + l[j])
                        l[i] = 1 + l[j];
                }
            }

            var max = 1;
            for (int i = 0; i < l.Length; i++)
            {
                if (max < l[i])
                    max = l[i];
            }

            return max;
        }
    }
}
