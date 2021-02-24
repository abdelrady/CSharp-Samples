using System;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = LCS("BCDBCDA", "ABECBA");
            Console.WriteLine(res);
        }

        private static int LCS(string a, string b)
        {
            int[][] l = new int[a.Length + 1][];
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = new int[b.Length + 1];
            }

            for (int i = 1; i < a.Length + 1; i++)
            {
                for (int j = 1; j < b.Length + 1; j++)
                {
                    if (a[i - 1] == b[j - 1])
                    {
                        l[i][j] = 1 + l[i - 1][j - 1];
                    }
                    else
                    {
                        l[i][j] = Math.Max(l[i][j - 1], l[i - 1][j]);
                    }
                    Console.Write(l[i][j] + " ");
                }
                Console.WriteLine();
            }

            return l[a.Length][b.Length];
        }
    }
}
