using System.Collections.Generic;
using System.IO;
using System;

class Solution
{

    // Complete the isBalanced function below.
    static string isBalanced(string s)
    {
        var stack = new Stack<char>();
        char lastChar = char.MinValue;
        var dic = new Dictionary<char, char>{{'{', '}'}, {'(', ')'}, {'[', ']'}};
        for (int i = 0; i < s.Length; i++)
        {
            var ch = s[i];
            if (dic.ContainsKey(ch))
            {
                stack.Push(ch);
            }
            else
            {
                if (stack.TryPeek(out lastChar) && ch == dic[lastChar])
                    stack.Pop();
                else return "NO";
            }
        }

        return stack.Count == 0 ? "YES" : "NO";
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var lines = File.ReadAllLines("d:\\input.txt");

        int t = Convert.ToInt32(lines[0]);

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = lines[tItr + 1];

            string result = isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}