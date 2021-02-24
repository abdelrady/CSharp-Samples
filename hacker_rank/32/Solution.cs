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
    // Complete the riddle function below.
    static long[] riddle(long[] arr)
    {
        // complete this function
        int N = arr.Length;
        long[] result = new long[N];
        long[] span = new long[N];

        var deckValues = new Stack<long>();
        var deckIndexes = new Stack<long>();
        deckIndexes.Push(-1L);

        // count number of ge elements to the left
        for (int i = 0; i < N; i++)
        {
            while (deckValues.Count > 0 && deckValues.Peek() >= arr[i])
            {
                deckValues.Pop();
                deckIndexes.Pop();
            }
            span[i] = i - deckIndexes.Peek() - 1;
            deckValues.Push(arr[i]);
            deckIndexes.Push((long)i);
        }

        // count number of ge elements to the right
        deckValues.Clear();
        deckIndexes.Clear();
        deckIndexes.Push((long)N);
        for (int i = N - 1; i >= 0; i--)
        {
            while (deckValues.Count > 0 && deckValues.Peek() >= arr[i])
            {
                deckValues.Pop();
                deckIndexes.Pop();
            }
            span[i] += deckIndexes.Peek() - i - 1;
            deckValues.Push(arr[i]);
            deckIndexes.Push((long)i);
        }

        // fill results
        for (int i = 0; i < N; i++)
        {
            result[(int)span[i]] = Math.Max(result[(int)span[i]], arr[i]);
        }

        // fill the gaps
        for (int i = N - 2; i >= 0; i--)
        {
            result[i] = Math.Max(result[i], result[i + 1]);
        }

        return result;

        //var maxLst = new List<long>();

        //maxLst.Add(arr.Max());

        //for (int windowSize = 2; windowSize < arr.Length; windowSize++)
        //{
        //    var tempLst = new List<long>();
        //    for (int j = 0; j < arr.Length - windowSize; j++)
        //    {
        //        tempLst.Add(arr.Skip(j).Take(windowSize).Min());
        //    }
        //    maxLst.Add(tempLst.Max());
        //}

        //maxLst.Add(arr.Min());

        //return maxLst.ToArray();
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp))
            ;
        long[] res = riddle(arr);

        textWriter.WriteLine(string.Join(" ", res));

        textWriter.Flush();
        textWriter.Close();
    }
}