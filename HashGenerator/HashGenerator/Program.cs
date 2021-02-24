using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HashidsNet;

namespace HashGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var dList = new decimal[] { 20, 20.01m, 20.5m, 20.5000m, 20.125m, 20.12500m, 0.000m };

            //foreach (var d in dList)
            //    Console.WriteLine(d.ToString("0.#####"));

            //Console.WriteLine(Guid.NewGuid());
            var hashService = new HashService();

            foreach (var i in hashService.Decode("pR3RBQwP"))
            {
                Console.WriteLine(i);
            }
            //return;
            //var x =
            //    "691|ASA - Alaska Chapter#709|ASA - Connecticut Chapter#707|ASA - Delaware Chapter#688|ASA - Georgia Chapter#687|ASA - Greater Kansas City#692|ASA - Hawaii Chapter#686|ASA - Houston Chapter#693|ASA - Idaho Chapter#703|ASA - Illinois Chapter#704|ASA - Indiana Chapter#701|ASA - Iowa Chapter#705|ASA - Kentucky Chapter#685|ASA - Los Angeles/Orange County/Inland Empire#684|ASA - Louisiana State Chapter#714|ASA - Maine Chapter#711|ASA - Massachusetts Chapter#683|ASA - Midwest Council#700|ASA - Minnesota Chapter#695|ASA - Montana Chapter#699|ASA - Nebraska Chapter#694|ASA - Nevada Chapter#713|ASA - New Hampshire Chapter#708|ASA - New York Chapter#697|ASA - North Dakota Chapter#682|ASA - North Florida#681|ASA - North Texas Chapter#680|ASA - Northwest Florida#690|ASA - Oregon Chapter#710|ASA - Rhode Island Chapter#679|ASA - Rio Grande Valley#678|ASA - San Antonio Chapter#698|ASA - South Dakota Chapter#677|ASA - Southwest Florida#712|ASA - Vermont Chapter#689|ASA - Washington Chapter#706|ASA - West Virginia Chapter#702|ASA - Wisconsin Chapter#696|ASA - Wyoming Chapter#676|ASA of Alabama#675|ASA of Arizona#715|ASA of Austin TX#674|ASA of Baltimore#673|ASA of California#672|ASA of Central Arkansas#671|ASA of Central Pennsylvania#670|ASA of Colorado#669|ASA of Greater Baton Rouge#668|ASA of Metro Washington#667|ASA of Michigan#666|ASA of Mississippi#665|ASA of New Jersey#664|ASA of New Mexico#663|ASA of Ohio#662|ASA of Oklahoma#661|ASA of Tennessee#660|ASA of the Carolinas#659|ASA of the Shenandoah Valley, Inc.#658|ASA of Utah#657|ASA of Western Pennsylvania#656|Bay Area Chapter, ASA, Inc.";
            //var url1 = "https://members.asaonline.com/ap/Membership/Application/nLveDGPk?id=";
            //var url2 = "https://members.asaonline.com/join-alabama?id=";
            //Console.WriteLine("Start");
            //foreach (var y in x.Split('#'))
            //{
            //    var arr = y.Split('|');
            //    var hash = hashService.Encode(int.Parse(arr[0]));
            //    Console.WriteLine(arr[1] + "|" + url1 + hash + "|" + url2 + hash);
            //}

            Console.WriteLine(hashService.Encode(int.Parse(Console.ReadLine())));
            Console.ReadLine();
            return;
            foreach (var i in hashService.Decode(""))
            {
                Console.WriteLine(i);
            }
            string input = "";
            while ((input = Console.ReadLine()) != "q")
            {
                Console.WriteLine(hashService.Encode(int.Parse(input)));
            }
        }
    }

    public class HashService
    {
        // I think this is thread-safe but not positive
        private Hashids _hasher;

        public HashService(string salt = "SaltySailorSavesSingingSwordfish", int minHashLength = 8, string alphabet = null)
        {
            if (string.IsNullOrWhiteSpace(alphabet))
            {
                _hasher = new Hashids(salt, minHashLength);
            }
            else
            {
                _hasher = new Hashids(salt, minHashLength, alphabet: alphabet);
            }
        }

        /// <summary>
        /// Encodes the provided numbers into a hashed string
        /// </summary>
        /// <param name="numbers">the numbers to encode</param>
        /// <returns>the hashed string</returns>
        public string Encode(params int[] numbers)
        {
            return _hasher.Encode(numbers);
        }

        /// <summary>
        /// Encodes the provided numbers into a hashed string
        /// </summary>
        /// <param name="numbers">the numbers to encode</param>
        /// <returns>the hashed string</returns>
        public string Encode(IEnumerable<int> numbers)
        {
            return _hasher.Encode(numbers.ToArray());
        }

        /// <summary>
        /// Decodes the provided hash into
        /// </summary>
        public virtual int[] Decode(string hash)
        {
            return _hasher.Decode(hash);
        }
    }
}
