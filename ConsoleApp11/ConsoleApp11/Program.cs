using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultedDictionary = new Dictionary<string, object> { { "Test", (string)null }, { "test03", 1 } };
            //var z = resultedDictionary.Where(p =>
            //        p.Value is string && string.IsNullOrEmpty(p.Value?.ToString()) : p.Value != null)
            //    .FirstOrDefault().Key;
            //Console.WriteLine(z);
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(1547497860000);
            Console.WriteLine(dateTimeOffset <= DateTime.UtcNow);

            var firstValueFound = resultedDictionary.FirstOrDefault(p => p.Key == "Test" && p.Value != null).Value;


            int x = 1;
            //Console.WriteLine(((bool)x));
            Dictionary<int, Dictionary<int, List<decimal>>> regsDiscountsValues = new Dictionary<int, Dictionary<int, List<decimal>>>();
            regsDiscountsValues.Add(1, new Dictionary<int, List<decimal>> { { 1, new List<decimal> { 1, 2, 3 } }, { 2, new List<decimal> { 1, 2, 3 } } });
            regsDiscountsValues.Add(2, new Dictionary<int, List<decimal>> { { 1, new List<decimal> { 1, 2, 3 } } });
            regsDiscountsValues.Add(3, new Dictionary<int, List<decimal>> { { 1, new List<decimal> { 1, 2, 3 } } });

            var discountsUsages = regsDiscountsValues.SelectMany(r => r.Value).GroupBy(r => r.Key, r => r.Value.Count)
                .Select((k) => new { Key = k.Key, Count = k.Sum() });

            foreach (var discountsUsage in discountsUsages)
            {
                Console.WriteLine(discountsUsage);
            }
            return;

            var list = new List<A>();

            Console.WriteLine(list.SelectMany(l => l.Bs).Sum(b => b.Price));
            Console.WriteLine(Enumerable.Empty<B>().Sum(b => b.Price));

            //Console.WriteLine(CreateSalt(2048));
            string _salt =
                "/YZ1VAMeoT61nDndVZVtekkC81N+qyFcORVOrda0pI2IaHo3OzYvYXISimnzB2G+74WISQ48zV0JTTngCoxpYK/NjO7k921iY0pIE9Ah3HwIzf63fIvnrjihpkeQ9VoncZWQxHcGuAqgBnAwDjVisuKGtmfRrBCaIUgcQ50cUu6Mp6RdWxIbezbncfj1ZzIJTR1tlx8ftJkCTiwa1wYtNBNkhfo7ECdeHjo7UN7K7Jllul9pPU63x5EcsC6QJn5uXeYZSpfL914Ci3chDrMJn1j+eV/D14neUnxsddj4VOH9D0b0/MDkMBMBuSxj6gf6wPYekxnrpqeAYzuUxRGO7quZzrPPUSRKeROEaUkHeq9pfyYe1NWv3IRCYgv7x7L1rUIhhuJw1Pv5zxZ68i52dmsgqeQKP8yWGR7SglqTlOEdAo1QAUwFSk9F27n1mCUZ3ghZV/6KLtO24dtNdV6LUMykGYRfy5GJoyzxGXvHDzxGYIKErRYIVSi1KS4fpxofJZaC9RaPJFBdZzdF3bXTc03j7zJuxpKFSuLuWbIRLWLDT/8dZGqpskG4kJDZavh7BqllPzrrb67+/va4ZKr/LIJVYEwI6l4XSTFTr0rmMJoeOq6Vu7InodqdwzXH5oj+eY3TrCqspUrgngqyi7wt9qTIZRL1GB2W6/AHGIYCmMt4EXxU4zGX1JnImJk6C5aCAa2G16Vm70S/CVZ6W+oyEsMZ47DF3cmvi/zJS2H2BeMiM1vtCSvlrQs0iD2z8Qxh6dXvdKJ5Vj8kHjt+cqqeREmssb8H5tQmoAbepepykRams1n2muzVlJjS42X31Epw8gTVYep8wCPgMK+rI6L5SQv74J7ZcjVQ+XRT5SmPuJ/B0tTlAeJ9Wt9+OFTlX9OOyFoR/IxgoJ7fRzxCfv2JXO0qDMICWcGbPrZDkgWDR6OyQTOjqV0L+9iaLO5JWMO+qfsNTxipeNQIJVWXQPJqdWhptjnBdus8QFketcX4JioGZQlYlbKcZjweaQhmPqX7Qx/EuzRxuPRSdXmq5NsIY5flZAqyWxtJDylW6H1bLRfa9HazVJI8IQg5is2MjNgAPQpoeZSkYzWmqIzW+Bu7MP5UA0vTY+H4H7MidS78LAnIONV7ZmXvpUCoTXtVilyCCHWfjPLjvqvLEV5AglBj9Tt+KKo+zF8HstqJlKA1sTz/ILJvu/rTGA9Enzuw88OIhOxg5dWE8G3CcC/HU4kQdCpKxmehWOYUB51sYp7uBlrlWK2CkanQG71TBylKTAFBK8hS7XZWpSKeps6iNmx4bM/2e6pXuEpO33DCpT96YT/ln6v2XO1fs9uSonVQ2VyYlviSLuWMAGyWyQOEElCtVg==";

            Console.WriteLine(GenerateSha256Hash("@bdelrady2018", _salt));
            Console.WriteLine(GenerateSha256Hash("@dmin2018", _salt));
            Console.WriteLine(GenerateSha256Hash("m@nager2018", _salt));

            string cardId = null;
            Console.WriteLine(cardId.StartsWith("ba_"));
        }


        public static string CreateSalt(int size)
        {
            var rang = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rang.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }


        public static string GenerateSha256Hash(string input, string salt)
        {
            var bytes = Encoding.UTF8.GetBytes(input + salt);
            var sha256Shashstring = new System.Security.Cryptography.SHA256Managed();
            var hash = sha256Shashstring.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }

    public class A
    {
        public List<B> Bs { get; set; }
    }

    public class B
    {
        public int Price { get; set; }
    }
}
