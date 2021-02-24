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

    // Complete the isValid function below.
    static string isValid(string s)
    {
        int[] arr = new int[128];
        int pad = (int) 'a';

        foreach (char c in s)
        {
            arr[c - pad]++;
        }

        var dic = new Dictionary<int, int>();
        foreach (var i in arr)
        {
            if (i != 0)
            {
                if (dic.ContainsKey(i))
                    dic[i]++;
                else dic.Add(i, 1);
            }
        }
        if(dic.Keys.Count > 2)
            return "NO";
        if (dic.Keys.Count == 0 || dic.Keys.Count == 1)
            return "YES";
        if (dic[dic.Keys.First()] == 1 || dic[dic.Keys.Last()] == 1)
            return "YES";
        return "NO";
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = isValid(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}