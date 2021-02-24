using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NodaTime;

namespace Tenant_Local_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //string productDomain = null;
            //Console.WriteLine("abc".Contains(productDomain));
            Console.WriteLine(DateTime.UtcNow);
            var utcNow = DateTime.Parse("2018/08/17 10:00:00 AM");
            Console.WriteLine(utcNow);
            var dt = ConvertFromUtc(utcNow, 85);
            Console.WriteLine(dt);
        }

        public static DateTime ConvertFromUtc(DateTime utcDateTime, int timeZoneId)
        {
            var kindCorrected = DateTime.SpecifyKind(utcDateTime, DateTimeKind.Utc);
            var tenantZone = //54 here got from dbo.Tenants->TimeZoneId
                DateTimeZoneProviders.Tzdb.GetZoneOrNull(SystemTimezoneOptionInfo.GetOrDefault((SystemTimezoneOption)timeZoneId).OlsonName);//"Etc/UTC";//_tenantSettings.Info.Timezone;
            return Instant.FromDateTimeUtc(kindCorrected).InZone(tenantZone).ToDateTimeUnspecified();
        }
    }
}
