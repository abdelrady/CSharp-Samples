using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = a3(new[] {'a', 'b', 'c'}, 1, 2);
            //Console.WriteLine(result);

            Console.WriteLine(f(1234));
            Console.WriteLine(f(12005));
            Console.WriteLine(f(1));
            Console.WriteLine(f(1000));
            Console.WriteLine(f(-12345));
        }

        static int f(int n)
        {
            var result = 0;
            var negativeNumber = false;
            if (n < 0)
            {
                negativeNumber = true;
                n *= -1;
            }
            while (n > 0)
            {
                result = (result * 10) + (n % 10);
                n /= 10;
            }
            return result * (negativeNumber ? -1 : 1);
        }

        static char[] a3(char[] a, int start, int length)
        {
            if (length < 0 || start < 0 || start + length - 1 >= a.Length)
            {
                return null;
            }

            char[] sub = new char[length];
            for (int i = start, j = 0; j < length; i++, j++)
            {
                sub[j] = a[i];
            }

            return sub;
        }

    }
}
