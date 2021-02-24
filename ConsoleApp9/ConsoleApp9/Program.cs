using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(numberOfCarryOperations(123, 456)); // 0
            Console.WriteLine(numberOfCarryOperations(555, 555)); // 3
            Console.WriteLine(numberOfCarryOperations(900, 11)); // 0
            Console.WriteLine(numberOfCarryOperations(145, 55)); // 2
            Console.WriteLine(numberOfCarryOperations(0, 0)); // 0
            Console.WriteLine(numberOfCarryOperations(1, 99999)); // 5
            Console.WriteLine(numberOfCarryOperations(999045, 1055)); // 5
            Console.WriteLine(numberOfCarryOperations(101, 809)); // 1
            Console.WriteLine(numberOfCarryOperations(189, 209)); // 1
        }

        static int numberOfCarryOperations(int a, int b)
        {
            var carryOps = 0;
            var carryValue = 0;
            while (a != 0 || b != 0)
            {
                int moda = a % 10, modb = b % 10;

                a = a / 10;
                b = b / 10;
                if (carryValue + moda + modb > 9)
                {
                    carryOps += 1;
                    carryValue = (carryValue + modb + moda) / 10;
                }
                else
                {
                    carryValue = 0;
                }
            }


            return carryOps;
        }
    }
}
