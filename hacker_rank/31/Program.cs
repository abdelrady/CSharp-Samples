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

    // Complete the largestRectangle function below.
    static long largestRectangle(int[] h)
    {
        var sizeStack = new Stack<int>();
        var posStack = new Stack<int>();
        int maxSize = 0, i, tempSize = 0, tempPos = 0;
        for (i = 0; i < h.Length; i++)
        {
            if (sizeStack.Count == 0 || h[i] > sizeStack.Peek())
            {
                sizeStack.Push(h[i]);
                posStack.Push(i);
            }
            else if(h[i] < sizeStack.Peek())
            {
                while (sizeStack.Count > 0 && sizeStack.Peek() > h[i])
                {
                    tempSize = sizeStack.Pop();
                    tempPos = posStack.Pop();
                    var tmpSize = tempSize * (i - tempPos);
                    maxSize = Math.Max(maxSize, tmpSize);
                }
                sizeStack.Push(h[i]);
                posStack.Push(tempPos);
            }
        }

        while (sizeStack.Count > 0)
        {
            tempSize = sizeStack.Pop();
            tempPos = posStack.Pop();
            var tmpSize = tempSize * (i - tempPos);
            maxSize = Math.Max(maxSize, tmpSize);
        }

        return maxSize;
    }

    private static int PopItem(Stack<int> sizeStack, int i, Stack<int> posStack, int maxSize)
    {
        var tmpSize = sizeStack.Pop() * (i - posStack.Pop());
        maxSize = Math.Max(maxSize, tmpSize);
        return maxSize;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
            ;
        long result = largestRectangle(h);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}