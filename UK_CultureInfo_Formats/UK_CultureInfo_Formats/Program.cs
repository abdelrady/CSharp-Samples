using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UK_CultureInfo_Formats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(((int?)null).ToString());
            CultureInfo FrCulture = new CultureInfo("it-IT");
            // Sets the CurrentCulture to fr-FR.
            Thread.CurrentThread.CurrentCulture = FrCulture;

            Console.WriteLine((10000.45).ToString("c", (NumberFormatInfo)NumberFormatInfo.CurrentInfo));
        }
    }
}
