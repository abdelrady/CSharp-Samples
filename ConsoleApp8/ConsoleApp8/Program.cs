using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            Console.WriteLine((s?.Trim().ToLower()));
            Console.WriteLine(s + "test");
            Console.WriteLine(null==null);
        }
    }
}
