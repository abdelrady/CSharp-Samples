using System;

namespace _37
{
    class Program
    {
        public bool IsPalindrome(string s)
        {
            if (s.Length == 0)
                return true;
            int lastIndex = 0;
            var arr = new char[s.Length];

            foreach (var ch in s)
            {
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch >= '0' && ch <= '9'))
                {
                    arr[lastIndex++] = ch.ToString().ToLower()[0];
                    Console.Write(arr[lastIndex - 1]);
                }
            }
            if (lastIndex == 0)
                return true;
            Console.WriteLine();
            for (int i = 0; i <= lastIndex / 2; i++)
            {
                if (arr[i] != arr[lastIndex - i - 1])
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(new Program().IsPalindrome("A man, a plan, a canal: Panama"));
        }
    }
}
