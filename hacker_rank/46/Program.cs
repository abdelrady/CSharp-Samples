using System;
using System.Text;

namespace _46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int myAtoi(string str)
        {
            if (str.Length ==0) return 0;
            int sign = 1, @base = 0, i = 0;
            while (str[i] == ' ')
                i++;
            if (str[i] == '-' || str[i] == '+')
                sign = str[i++] == '-' ? -1 : 1;
            while (i < str.Length && str[i] >= '0' && str[i] <= '9')
            {
                if (@base > int.MaxValue / 10 || (@base == int.MinValue / 10 && str[i] - '0' > 7))
                {
                    return (sign == 1) ? int.MaxValue : int.MinValue;
                }
                @base = 10 * @base + (str[i++] - '0');
            }
            return @base * sign;
        }
    }

    public class Solution
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
                return 0;
            var foundFirst = false;
            var numberStr = new StringBuilder();
            for (var i = 0; i < str.Length; i++)
            {
                if (IsValid(str[i], !foundFirst))
                {
                    if (str[i] != ' ')
                    {
                        foundFirst = true;
                        numberStr.Append(str[i]);
                    }
                }
                else break;
            }

            if (numberStr.Length < 1 || (numberStr.Length == 1 && IsValidSign(numberStr[0]))) return 0;
            var numberS = numberStr.ToString();

            if (long.TryParse(numberS, out var num))
            {
                if (num > int.MaxValue) return int.MaxValue;
                if (num < int.MinValue) return int.MinValue;

                return (int)num;
            }
            if (numberS.Length > 11 && numberS[0] != '-') return int.MaxValue;
            if (numberS.Length > 11 && numberS[0] != '+') return int.MinValue;
            return 0;
        }

        public bool IsValid(char ch, bool first = false)
        {
            return (first && (ch == ' ' || IsValidSign(ch))) || (ch >= '0' && ch <= '9');
        }

        public bool IsValidSign(char ch)
        {
            return ch == '+' || ch == '-';
        }
    }
}
