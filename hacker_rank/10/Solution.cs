using System;
using System.Collections.Generic;
using System.Text;

namespace _9
{
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

        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            long completeParts = n / s.Length;
            var aOccurrences = s.Select((c, i) => new { c, i }).Where((x)=> x.c == 'a').Select(x=>x.i);

            return completeParts * aOccurrences.Count() + (aOccurrences.Count(i => i < n % s.Length));
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }


}
