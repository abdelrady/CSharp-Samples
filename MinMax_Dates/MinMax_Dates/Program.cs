using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var Date1 = DateTime.Now.AddDays(-3);
            var Date2 = DateTime.Now.AddDays(1);

            var dt = new DateTime(Math.Min(Date1.Ticks, Date2.Ticks));

            Console.WriteLine(dt);
        }
    }
}
