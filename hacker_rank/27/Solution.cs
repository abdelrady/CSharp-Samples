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

    // Complete the substrCount function below.
    static long substrCount(int n, string s)
    {
        int tot = 0, cnt = 0;
        var prev = char.MinValue;
        for (int i = 0; i < n; i++)
        {
            cnt += 1;
            var v = s[i];
            if (i > 0 && (prev != v))
            {
                var j = 1;
                while (((i - j) >= 0) && ((i + j) < n) && j <= cnt)
                {
                    if (s[i - j] == prev && prev == s[i + j])
                    {
                        tot += 1;
                        j += 1;
                    }
                    else break;
                }

                cnt = 1;
            }

            tot += cnt;
            prev = v;
        }

        return tot;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        long result = substrCount(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}