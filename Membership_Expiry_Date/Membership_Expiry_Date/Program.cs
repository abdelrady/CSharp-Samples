using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership_Expiry_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetExpiryDate(1, 18));
        }

        static DateTime GetExpiryDate(byte? FixedAnnualRenewalMonth, short durationMonths)
        {
            var startDate = DateTime.Now;
            var nextRenewalDate = new DateTime(startDate.Year, FixedAnnualRenewalMonth.Value, 1);

            if (nextRenewalDate <= startDate)
                nextRenewalDate = nextRenewalDate.AddMonths(durationMonths);

            if (nextRenewalDate.MonthsDiff(startDate) > durationMonths)
                nextRenewalDate = nextRenewalDate.AddMonths(-1 * durationMonths);

            return nextRenewalDate;
        }


    }

    public static class Extentions
    {
        public static int MonthsDiff(this DateTime start, DateTime end)
        {
            return (start.Year * 12 + start.Month) - (end.Year * 12 + end.Month);
        }
    }

}
