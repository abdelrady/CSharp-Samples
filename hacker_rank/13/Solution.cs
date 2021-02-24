using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries)
    {
        var dic = new Dictionary<int, long>();
        foreach (var item in queries)
        {
            int a = item[0], b = item[1], k = item[2];
            dic[a] = dic.ContainsKey(a) ? dic[a] + k : k;
            if (b + 1 <= n) dic[b + 1] = dic.ContainsKey(b + 1) ? dic[b + 1] - k : -1 * k;
        }

        long tempMax = 0;
        long max = 0;
        for (int i = 1; i <= n; i++)
        {
            tempMax += dic.ContainsKey(i) ? dic[i] : 0;
            if (tempMax > max) max = tempMax;
        }
        return max;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++)
        {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        long result = arrayManipulation(n, queries);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
