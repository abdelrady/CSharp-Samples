using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace _48
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution().ReverseWords(new char[]{'t', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' });
            foreach (var c in s)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }
    }
    public class Solution
    {
        public char[] ReverseWords(char[] s)
        {
            if (string.IsNullOrEmpty(new String(s))) return s;
            Reverse(s, 0, s.Length - 1);

            var start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    Reverse(s, start, i-1);
                    start = i + 1;
                }
            }
            Reverse(s, start, s.Length - 1);

            return s;
        }

        public void Reverse(char[] c, int start, int end)
        {
            for (int i = 0; i <= (end - start) /2; i++)
            {
                var temp = c[start + i];
                c[start + i] = c[end - i];
                c[end - i] = temp;
            }
        }


        public char[] ReverseWords2(char[] s)
        {
            if (string.IsNullOrEmpty(new String(s))) return s;
            var r = new char[s.Length];
            var rIndex = 0;
            var endSpaceIndex = s.Length - 1;
            var st = new Stack<Char>();

            for (var i = s.Length - 1; i >= 0; i--)
            {
                var startSpaceIndex = i;
                if (s[i] != ' ')
                {
                    st.Push(s[i]);
                }
                else
                {
                    while (st.Count > 0)
                    {
                        r[rIndex++] = st.Pop();
                    }
                    r[rIndex++] = ' ';
                }
            }
            while (st.Count > 0)
            {
                r[rIndex++] = st.Pop();
            }

            for (var i = s.Length - 1; i >= 0; i--)
            {
                s[i] = r[i];
            }
            return r;
        }

    }
}
