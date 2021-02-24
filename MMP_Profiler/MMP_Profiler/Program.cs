using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using MicroNet.MMP.Data;
using MicroNet.MMP.Models.MIC;

namespace MMP_Profiler
{
    class Program
    {
        static void Main(string[] args)
        {
            var _db = new MicroNet.MMP.Data.MzDB(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MemberZone_Instance1;Integrated Security=True;Max Pool Size=1024;MultipleActiveResultSets=True;Application Name=GrowthZone_Local;ApplicationIntent=ReadWrite");

            //var cn = mzdb.EventAttendees.Count();

            //Console.WriteLine(cn);
            var entity = _db.Events
                .Where(e => e.TenantId == 2 && e.EventId == 7 && e.IsDeleted == false)
                .ProjectTo<EventDetailModel>()
                .SingleOrDefault();

            Console.WriteLine(entity.EventId);
        }
    }
}
