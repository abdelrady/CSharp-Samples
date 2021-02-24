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

    // Complete the freqQuery function below.
    static List<int> freqQuery(List<List<int>> queries)
    {
        var dic = new Dictionary<int, int>();
        var valuesDic = new Dictionary<int, int>();
        var res = new List<int>();
        var cnt = 0;
        foreach (var query in queries)
        {
            var number = query.ElementAt(1);
            switch (query.ElementAt(0))
            {
                case 1:
                    if (dic.ContainsKey(number))
                    {
                        if (valuesDic.ContainsKey(dic[number]))
                            valuesDic[dic[number]] -= 1;
                        dic[number] += 1;
                    }
                    else
                    {
                        dic.Add(number, 1);
                    }
                    if (valuesDic.ContainsKey(dic[number]))
                        valuesDic[dic[number]] += 1;
                    else valuesDic.Add(dic[number], 1);
                    break;
                case 2:
                    if (dic.ContainsKey(number) && dic[number] > 0)
                    {
                        if (valuesDic.ContainsKey(dic[number]))
                            valuesDic[dic[number]] -= 1;
                        dic[number] -= 1;
                        if (valuesDic.ContainsKey(dic[number]))
                            valuesDic[dic[number]] += 1;
                        else valuesDic.Add(dic[number], 1);
                    }
                    break;
                case 3:
                    var r1 = number > 0 && valuesDic.ContainsKey(number) && valuesDic[number] > 0 ? 1 : 0;
                    res.Add(r1);
                    cnt = (number == 5) ? cnt + 1 : cnt;
                    break;
            }
        }

        return res;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var lines = File.ReadAllLines("d:\\input.txt");

        int q = Convert.ToInt32(lines[0].Trim());

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(lines[i+1].TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> ans = freqQuery(queries);

        textWriter.WriteLine(String.Join("\n", ans));

        textWriter.Flush();
        textWriter.Close();
    }
}