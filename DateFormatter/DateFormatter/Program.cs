using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = DateTime.Parse("2018-05-29");
            Console.WriteLine(dt.Date.ToString());
            Console.WriteLine(dt.Date.ToString("d"));
            Console.WriteLine(dt.Date.ToString("s"));
        }
    }
}
