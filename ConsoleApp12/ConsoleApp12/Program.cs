using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main()
        {
            var expando = new ExpandoObject();
            var expandoDictionary = expando as IDictionary<string, object>;
            expandoDictionary["number"] = 0;
            dynamic result = expando;
            Console.WriteLine(result.number==null);
            Console.WriteLine(IsNull(result.number));
        }

        public static bool IsDefaultTypeValue<T>(T value) where T : struct
        {
            bool isDefault = value.Equals(default(T));

            return isDefault;
        }

        public static bool IsNull(dynamic mergeData)
        {
            return mergeData?.GetType()?.IsValueType ? IsDefaultTypeValue(mergeData) : mergeData == null;
        }
    }
}
