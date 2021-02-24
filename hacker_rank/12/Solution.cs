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
    // Complete the minimumSwaps function below.
    //3 5 2 4 1 6 7
    //1 2 3 4 5 6 7
    //4
    //1 2 3 4
    static int minimumSwaps(int[] arr)
    {
        int minSwap = 0;
        var tempDic = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = -1; int min = arr[i];
            if(tempDic.Count > 0)
            {
                for (int z = 0; z < tempDic.Count; z++)
                {
                    if (min > tempDic.ElementAt(z).Key)
                    {
                        minIndex = tempDic.ElementAt(z).Value;
                        min = tempDic.ElementAt(z).Key;
                    }
                }
                if (minIndex != -1)
                {
                    var temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                    minSwap++;
                    tempDic.Remove(min);
                }
                if (tempDic.ContainsKey(min)) tempDic.Remove(min);
            }
            else
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (min > arr[j])
                    {
                        minIndex = j;
                        min = arr[j];
                    }
                    if (arr[i] > arr[j])
                    {
                        tempDic.Add(arr[j], j);
                    }
                }
                if (minIndex != -1)
                {
                    var temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                    minSwap++;
                    tempDic.Remove(min);
                }
            }
        }

        return minSwap;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
