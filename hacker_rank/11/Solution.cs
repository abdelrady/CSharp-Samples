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

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {

        var sumList = new List<int>();
        for (int i = 0; i < arr.Length - 2; i++)
        {
            for (int j = 0; j < arr[i].Length - 2; j++)
            {
                var sum = 0;
                for (int k = 0; k < 3; k++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        if (k == 1 && (z == 0 || z == 2)) continue;
                        sum += arr[i + k][j + z];
                    }
                }
                sumList.Add(sum);
            }
        }
        return sumList.Max();
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
