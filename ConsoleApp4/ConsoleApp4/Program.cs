using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var str =
                "{EventId:0,RegistrationStartDate:'2018-06-26T09:39:47.1767581Z',AllowMultipleTypesPurchase:true,IsEmailDomainActivationDisabled:true,MemberSecurityMode:0,forceSave:false}";
            var obj = JsonConvert.DeserializeObject<dynamic>(str);

            Console.WriteLine(obj.RegistrationStartDate);
        }
    }
}
