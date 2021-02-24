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

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note)
    {
        var hash = new Dictionary<string, int>();
        //s1.ToCharArray().ToHashSet();
        foreach (var s in magazine)
        {
            if (hash.ContainsKey(s))
                hash[s] = hash[s] + 1;
            else hash.Add(s, 1);
        }
        var notFound = false;
        foreach (var s in note)
        {
            if (!hash.ContainsKey(s) || hash[s] <= 0)
            {
                notFound = true;
                break;
            }
            hash[s] = hash[s] - 1;
        }
        Console.WriteLine(notFound ? "No" : "Yes");
    }

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
