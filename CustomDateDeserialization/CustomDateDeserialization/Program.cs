using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CustomDateDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //var str2 = "{\"DueDateBetween\":{\"Range\":0,\"StartDate\":\"Jan 27, 2000\",\"EndDate\":\"Feb 14, 2019\"}}";
            var str2 = "{\"DueDateBetween\":{\"Range\":0,\"StartDate\":\"Jan 01, 2000\",\"EndDate\":\"Feb 01, 2019\"}}";
            var myObj = JsonConvert.DeserializeObject<MyClass>(str2);
            Console.WriteLine(myObj.DueDateBetween.StartDate);
            Console.WriteLine(myObj.DueDateBetween.EndDate);
        }
    }

    public class MyClass
    {
        public DateRange DueDateBetween { get; set; }
    }

    public class DateFormatConverter : IsoDateTimeConverter
    {
        public DateFormatConverter(string format)
        {
            DateTimeFormat = format;
        }
    }

    public class DateRange
    {
        public const string FutureDates = "['ThisWeek', 'ThisMonth', 'ThisQuarter', 'ThisYear']";

        [JsonConverter(typeof(DateFormatConverter), "MMM d, yyyy")]
        public DateTime? StartDate { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "MMM d, yyyy")]
        public DateTime? EndDate { get; set; }

        public int? MaxRangesInDays { get; set; }

        public int? RangeSelector { get; set; }

        public int Range { get; set; }

        [JsonIgnore]
        public bool HasValue => StartDate.HasValue && EndDate.HasValue;

        [JsonIgnore]
        public bool HasNotValue => StartDate.HasValue == false && EndDate.HasValue == false;

    }
}
