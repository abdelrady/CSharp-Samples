using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culture_Currency_Symbol
{
    class Program
    {
        static void Main(string[] args)
        {
            var isTrue = new bool[0] { }.All(x => x == true);
            Console.WriteLine(isTrue);
            //
            CultureInfo ci = new CultureInfo("en-GB");
            var symbol = ci.NumberFormat.CurrencySymbol;
            Console.WriteLine(symbol);
        }
    }
}
