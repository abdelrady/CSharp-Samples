using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = SponsorDisplayOn.Email;
            e |= SponsorDisplayOn.EventDetail;

            Console.WriteLine(e.HasFlag(SponsorDisplayOn.EventDetail));
        }
    }

    [Flags]
    public enum SponsorDisplayOn
    {
        EventDetail = 0x1,
        EventRegistration = 0x2,
        Email = 0x4
    }
}
