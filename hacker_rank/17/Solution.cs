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
    static int check_anagram(string a, string b)
    {
        int[] first = Enumerable.Repeat(0, 26).ToArray(), second = Enumerable.Repeat(0, 26).ToArray();
        int c = 0;

        for (int i = 0; i < a.Length; i++)
        {
            first[a[c] - 'a']++;
            second[b[c] - 'a']++;
            c++;
        }

        for (c = 0; c < 26; c++)
        {
            if (first[c] != second[c])
                return 0;
        }

        return 1;
    }

    // Complete the sherlockAndAnagrams function below.
    static int sherlockAndAnagrams(string s)
    {
        var permDic = new List<string>();
        // 1- get permutations
        for (int i = 1; i < s.Length; i++)
        {
            for (int j = 0; j + i <= s.Length; j++)
            {
                var item = s.Substring(j, i);
                permDic.Add(item);
            }
        }

        int sum = 0;
        
        foreach (var grp in permDic.GroupBy(item => item.Length))
        {
            var perms = grp.ToList();
            for (int i = 0; i < perms.Count; i++)
            {
                for (int j = i + 1; j < perms.Count; j++)
                {
                    sum += check_anagram(perms[i], perms[j]);
                }
            }
        }
        return sum;
        //var permDic = new Dictionary<string, int>();
        //// 1- get permutations
        //for (int i = 1; i < s.Length; i++)
        //{
        //    for (int j = 0; j + i <= s.Length; j ++)
        //    {
        //        var item = s.Substring(j, i);
        //        if (!permDic.ContainsKey(item))
        //        {
        //            permDic.Add(item, 1);
        //        }
        //        else permDic[item] = permDic[item] + 1;
        //    }
        //}

        //int sum = 0;
        //var fibDic = new Dictionary<int, int>();
        //foreach (KeyValuePair<string, int> kv in permDic)
        //{
        //    if(kv.Value > 1)
        //    {
        //        // sum Fib(x)
        //        int fib = 0;
        //        for (int i = kv.Value; i > 0; i--)
        //        {
        //            if (fibDic.ContainsKey(kv.Value))
        //            {
        //                fib += fibDic[kv.Value];
        //                break;
        //            }
        //            else
        //            {
        //                fib += (i - 1);
        //            }
        //        }
        //        if (!fibDic.ContainsKey(kv.Value))
        //            fibDic[kv.Value] = fib;
        //        sum += fib;
        //    }
        //}

        //foreach (var grp in permDic.GroupBy(kv => kv.Key.Length).Where(grp=>grp.Key > 1))
        //{
        //    var perms = grp.ToList();
        //    for (int i = 0; i < perms.Count; i++)
        //    {
        //        for (int j = i + 1; j < perms.Count; j++)
        //        {
        //            sum += check_anagram(perms[i].Key, perms[j].Key);
        //        }
        //    }
        //}
        //return sum;
    }



    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = sherlockAndAnagrams(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
