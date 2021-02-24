using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().ReverseWords("  hello world!  "));
        }
        public string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s)) return "";

            var sb = new StringBuilder();
            var st = new Stack<string>();

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    sb.Append(s[i]);
                }
                else if (sb.Length > 0)
                {
                    st.Push(sb.ToString());
                    sb.Clear();
                }
            }
            if (sb.Length > 0)
            {
                st.Push(sb.ToString());
                sb.Clear();
            }
            return string.Join(" ", st.ToList());
        }
    }
}
