using System;

namespace fib
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new FibonacciClass(9).Calculate(9);
            Console.WriteLine();
            Console.WriteLine(res);
        }
    }
    public class FibonacciClass
    {
        private readonly long[] _calculatedResult;
        public FibonacciClass(long number)
        {
            _calculatedResult = new long[number + 1];
        }

        public long Calculate(long number)
        {
            if (number == 0)
                return 0;
            if (number == 1)
                return 1;
            if (_calculatedResult[number] != 0)
                return _calculatedResult[number];
            try
            {
                checked
                {
                    Console.WriteLine(number);
                    _calculatedResult[number] = Calculate(number - 1) + Calculate(number - 2);
                }
            }
            catch (Exception e)
            {
                string reason = string.Format("Fib(>{0}) will cause a 64-bit integer overflow.", number - 1);
                var argumentException = new ArgumentOutOfRangeException(reason);
                throw argumentException;
            }
            //if (_calculatedResult[number] > long.MaxValue)
            return _calculatedResult[number];
        }
    }
}
