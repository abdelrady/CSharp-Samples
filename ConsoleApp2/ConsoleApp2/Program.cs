using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NodaTime;

namespace ConsoleApp2
{
    class Program
    {
        public static DateTime ConvertFromUtc(DateTime utcDateTime, DateTimeZone tenantZone)
        {
            var kindCorrected = DateTime.SpecifyKind(utcDateTime, DateTimeKind.Utc);
            return Instant.FromDateTimeUtc(kindCorrected).InZone(tenantZone).ToDateTimeUnspecified();
        }

        static void Main(string[] args)
        {
            decimal x = 10.4M;
            Console.WriteLine(x.ToString("N2"));
            var timeZone =
                DateTimeZoneProviders.Tzdb.GetZoneOrNull(
                    SystemTimezoneOptionInfo.GetOrDefault(SystemTimezoneOption.America_Chicago).OlsonName);
            Console.WriteLine(ConvertFromUtc(DateTime.UtcNow, timeZone));
        }
    }
}
