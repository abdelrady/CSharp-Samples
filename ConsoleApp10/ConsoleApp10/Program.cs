using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findWord(new[] {"U>N", "G>A", "R>Y", "H>U", "N>G", "A>R"})); // HUNGARY
            Console.WriteLine(findWord(new[] { "I>F", "W>I", "S>W", "F>T" })); // SWIFT
            Console.WriteLine(findWord(new[] { "R>T", "A>L", "P>O", "O>R", "G>A", "T>U", "U>G" })); // PORTUGAL
            Console.WriteLine(findWord(new[] { "W>I", "R>L", "T>Z", "Z>E", "S>W", "E>R", "L>A", "A>N", "N>D", "I>T" })); // SWITZERLAND
        }

        static string findWord(string[] arr)
        {
            var dic = arr.Select(s => s.Split('>')).ToDictionary(s => s[0][0], s => s[1][0]);
            
            //find first char
            var dicValues = dic.Values;
            var firstChar = dic.Keys.FirstOrDefault(k => !dicValues.Contains(k));
            if (firstChar == default(char))
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            sb.Append(firstChar);

            while (dic.ContainsKey(firstChar))
            {
                firstChar = dic[firstChar];
                sb.Append(firstChar);
            }

            return sb.ToString();
        }
    }
}
