using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumFlags_Test
{
    [Flags]
    public enum GlobalMergeDataFlags : int
    {
        None = 0,
        Contact = (1 << 0),
        Group = (1 << 1),
        Directory = (1 << 2),
        Invoice = (1 << 3),
        Statement = (1 << 4),
        Membership = (1 << 5),
        Event = (1 << 6),
        Project = (1 << 7),
        Content = (1 << 8),
        Tenant = (1 << 9),
        FundraisingCampaign = (1 << 10),
        EventReminder = (1 << 11),
        Sale = (1 << 12),
        EventAttendee = (1 << 13),
        MeetingInvitee = (1 << 14),
        ForumMessage = (1 << 15),
    }

    class Program
    {
        static void Main(string[] args)
        {
            var e = GlobalMergeDataFlags.Event | GlobalMergeDataFlags.Tenant;
            Console.WriteLine((int)e);
            Console.ReadKey();
        }
    }
}
