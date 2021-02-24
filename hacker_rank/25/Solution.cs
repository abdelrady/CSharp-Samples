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

    // Complete the countTriplets function below.
    static long countTriplets(List<long> arr, long r)
    {
        //long triplets = 0;
        //for (int i = 0; i < arr.Count; i++)
        //{
        //    var l = arr[i];
        //    var findNext2 = arr.Skip(i + 1).Count(a => a == (l * r));
        //    if (findNext2 > 0)
        //    {
        //        var findNext3 = arr.Skip(i + 2).Count(a => a == (l * r * r));
        //        if (findNext3 > 0)
        //        {
        //            triplets += (findNext2 * findNext3);
        //        }
        //    }
        //}

        //return triplets;
        var dic = new Dictionary<long, int>();
        long triplets = 0, tempTriplets = 1;
        foreach (var l in arr)
        {
            if (dic.ContainsKey(l))
                dic[l] += 1;
            else dic.Add(l, 1);
        }

        if (r == 1)
        {
            foreach (var pair in dic.Where(d=>d.Value >= 3))
            {
                long res = (pair.Value / 6) * (pair.Value - 1) * (pair.Value - 2);
                triplets += res;
            }

            return triplets;
        }

        for (int i = 0; i < arr.Count; i++)
        {
            var l = arr[i];
            if (dic.ContainsKey(l * r))
            {
                tempTriplets *= dic[l * r];
                if (dic.ContainsKey(l * r * r))
                {
                    tempTriplets *= dic[l * r * r];
                    triplets += tempTriplets;
                }
            }
            tempTriplets = 1;
        }

        return triplets;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var lines = File.ReadAllLines("d:\\input.txt");

        string[] nr = lines[0].TrimEnd().Split(' ');

        int n = Convert.ToInt32(nr[0]);

        long r = Convert.ToInt64(nr[1]);

        List<long> arr = lines[1].TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        long ans = countTriplets(arr, r);

        textWriter.WriteLine(ans);

        textWriter.Flush();
        textWriter.Close();
    }
}