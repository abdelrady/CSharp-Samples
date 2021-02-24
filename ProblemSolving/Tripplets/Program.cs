using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

namespace Tripplets
{
    class Solution
    {

        // Complete the triplets function below.
        static long triplets(int[] a, int[] b, int[] c)
        {
            a = a.Distinct().ToArray();
            b = b.Distinct().ToArray();
            c = c.Distinct().ToArray();
            Array.Sort(a);
            //Array.Sort(b, (i, j) => j.CompareTo(i));
            Array.Sort(b);
            Array.Sort(c);
            long count = 0;
            int i = 0, j = 0, k = 0;
            while (j < b.Length)
            {
                while (i < a.Length && a[i] <= b[j])
                {
                    i++;
                }
                while (k < c.Length && b[j] >= c[k])
                {
                    k++;
                }

                count += k * i;
                j++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] lenaLenbLenc = Console.ReadLine().Split(' ');

            int lena = Convert.ToInt32(lenaLenbLenc[0]);

            int lenb = Convert.ToInt32(lenaLenbLenc[1]);

            int lenc = Convert.ToInt32(lenaLenbLenc[2]);

            int[] arra = Array.ConvertAll(Console.ReadLine().Split(' '), arraTemp => Convert.ToInt32(arraTemp))
                ;

            int[] arrb = Array.ConvertAll(Console.ReadLine().Split(' '), arrbTemp => Convert.ToInt32(arrbTemp))
                ;

            int[] arrc = Array.ConvertAll(Console.ReadLine().Split(' '), arrcTemp => Convert.ToInt32(arrcTemp))
                ;
            long ans = triplets(arra, arrb, arrc);

            textWriter.WriteLine(ans);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
