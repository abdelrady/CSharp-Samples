using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicVSDic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d = new Dictionary<int?, object> {{1, new DateTime()}};
            dynamic d2 = new KeyValuePair<int?, object>(0, DateTime.Now);
            dynamic d3 = new KeyValuePair<int?, object>();
            //Console.WriteLine(Extensions.IsDefault(d2));
            //Console.WriteLine(Extensions.IsDefault(d3));

            //var type = (Type) d2.GetType();
            //Console.WriteLine(new Program().GetDefault(type));
            //Console.WriteLine(d2 is KeyValuePair<int?, object>);
            var lst = new List<Test>();
            lst.Add(new Test{MergeData = d});
            lst.Add(new Test { MergeData = d2});
            lst.Add(new Test { MergeData = d3});
            lst.Add(new Test { MergeData = new Program()});
            var anyIsNull = lst.Any(l =>
                l.MergeData.GetType().IsValueType
                    ? Extensions.IsDefault(l.MergeData)
                    : l.MergeData == null);
            Console.WriteLine(anyIsNull);
        }
        public object GetDefault(Type t)
        {
            return this.GetType().GetMethod("GetDefaultGeneric").MakeGenericMethod(t).Invoke(this, null);
        }

        public T GetDefaultGeneric<T>()
        {
            return default(T);
        }
    }

    class Test
    {
        public dynamic MergeData { get; set; }
    }
    public static class Extensions
    {
        public static bool IsDefault<T>(this T value) where T : struct
        {
            bool isDefault = value.Equals(default(T));

            return isDefault;
        }
    }
}
