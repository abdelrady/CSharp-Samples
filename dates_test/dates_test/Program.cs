using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dates_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "2019-06-01";
            DateTime tempDateTime;
            var dateValue = DateTime.TryParse(value, out tempDateTime) ? tempDateTime : (DateTime?)null;
            var result = string.Format("{0:d}", dateValue);
            Console.WriteLine(result);
            //string value = "2018-09-17 22:13:36.9497992 -09:00";
            //string value = "01.10.2017 16:11";
            //string value = "2019-06-01";
            //DateTime tempDateTime;
            //var dateValue1 = Convert.ToDateTime(value, CultureInfo.InvariantCulture);
            //Console.WriteLine(dateValue1.ToUniversalTime());
            //var dateValue = DateTime.TryParse(value, null,
            //    DateTimeStyles.AssumeUniversal, out tempDateTime) ? tempDateTime : (DateTime?)null;
            //Console.WriteLine(dateValue.Value.Kind);
            //string result = string.Format("{0:d}", dateValue.Value);
            //Console.WriteLine(result);
        }

        private static DateTime GetUniDate(string dateString)
        {
            DateTime dateTime;

            if (DateTime.TryParse(dateString, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out dateTime))
            {
                return dateTime.ToUniversalTime();
            }

            if (DateTime.TryParse(dateString, CultureInfo.CurrentCulture, DateTimeStyles.AssumeUniversal, out dateTime))
            {
                return dateTime.ToUniversalTime();
            }

            if (DateTime.TryParse(dateString, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out dateTime))
            {
                return dateTime.ToUniversalTime();
            }

            return DateTime.Now;
        }
    }
}
