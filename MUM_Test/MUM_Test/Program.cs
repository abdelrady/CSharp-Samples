using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MUM_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(hasNValues(new [] { 1, 2, 2, 1 }, 2));
            //Console.WriteLine(hasNValues(new [] { 1, 1, 1, 8, 1, 1, 1, 3, 3 }, 3));
            //Console.WriteLine(hasNValues(new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10));
            //Console.WriteLine(hasNValues(new [] { 1, 2, 2, 1 }, 3));
            //Console.WriteLine(hasNValues(new [] { 1, 1, 1, 8, 1, 1, 1, 3, 3 }, 2));
            //Console.WriteLine(hasNValues(new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 20));

            //Console.WriteLine(isRapidlyIncreasing(new [] { 1, 3, 9, 27 }));
            //Console.WriteLine(isRapidlyIncreasing(new [] { 1, 3, 200, 500 }));
            //Console.WriteLine(isRapidlyIncreasing(new [] { 1 }));
            //Console.WriteLine(isRapidlyIncreasing(new [] { 1, 3, 9, 26 }));
            //Console.WriteLine(isRapidlyIncreasing(new [] { 1, 3, 7, 26 }));
            //Console.WriteLine(isRapidlyIncreasing(new [] { 1, 3, 8, 26 }));


            //getPrimeNumbers(3).ToList().ForEach(Console.WriteLine);

            Console.WriteLine(isPrimeHappy(5));
            Console.WriteLine(isPrimeHappy(25));
            Console.WriteLine(isPrimeHappy(32));
            Console.WriteLine(isPrimeHappy(8));
            Console.WriteLine(isPrimeHappy(2));
        }

        static int isPrimeHappy(int n)
        {
            //1- get list of prime numbers less than n
            var primesList = new List<int>();
            for (int i = 2; i < n; i++)
            {
                var divisable = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        divisable = true;
                        break;
                    }
                }
                if (!divisable) primesList.Add(i);
            }

            //2- get sum of primes list
            long primesSum = 0;
            for (int i = 0; i < primesList.Count; i++)
            {
                primesSum += primesList[i];
            }

            //3- check prime happy conditions
            return primesList.Count > 0 && primesSum % n == 0 ? 1 : 0;
        }

        int isPrimeHappy2(int n)
        {
            var primeList = getPrimeNumbers(n);
            return primeList.Length > 0 && getSum(primeList) % n == 0 ? 1 : 0;
        }

        int[] getPrimeNumbers(int n)
        {
            var primesList = new List<int>();
            var divisable = false;
            for (int i = 2; i < n; i++)
            {
                divisable = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        divisable = true;
                        break;
                    }
                }
                if (!divisable) primesList.Add(i);
            }
            return primesList.ToArray();
        }

        long getSum(int[] arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static int isRapidlyIncreasing(int[] a)
        {
            if (a == null || a.Length == 0) return 0;
            long sumOfPrevious = 0;
            var result = 1;
            for (int i = 0; i < a.Length; i++)
            {
                result = a[i] > (2 * sumOfPrevious) ? 1 : 0;
                if (result == 0) return result;
                sumOfPrevious += a[i];
            }
            return result;
        }

        static int hasNValues(int[] a, int n)
        {
            if (a == null) return 0;
            var hashSet = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (hashSet.Count > n)
                    return 0;
                if (!hashSet.Contains(a[i]))
                    hashSet.Add(a[i]);
            }
            return hashSet.Count == n ? 1 : 0;
        }
    }
}
