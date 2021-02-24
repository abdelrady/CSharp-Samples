using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string eventAddress = null;
            eventAddress?.Trim();

            Console.WriteLine(default(SystemEmailAddressTypeOption));
            var x = new MyClass()
            {
                Name = "Rady"
            };

            var y = new MyClass()
            {
                Name = "Eman"
            };

            var str = x.Name;
            string newStr1 = CheckIfDiff(ref str, "Moaz");
            Console.WriteLine(str);
            Console.WriteLine(x.Name);
            string newStr2 = CheckIfDiff(ref str, y.Name);
            Console.WriteLine(x.Name);

        }

        private static string CheckIfDiff(ref string oldVal, string newVal)
        {
            if (!string.IsNullOrEmpty(newVal) && oldVal != newVal)
                oldVal = newVal;
            return oldVal;
        }

        public class MyClass
        {   
            public string Name { get; set; }
        }

        public enum SystemEmailAddressTypeOption : byte
        {
            Other = 0,
            Primary = 1, // Obsolete
            Work = 2,
            Secondary = 3, // Obsolete
            Personal = 4,
        }

    }
}
