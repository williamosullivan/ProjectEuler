using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            LargestPrime();
        }

        private static void LargestPrime()
        {
            long number = 600851475143;
            long biggest = 1;
            for (long i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    long candidate = i;
                    if ((candidate & 1) == 0)
                    {
                        if (candidate == 2)
                        {
                            Console.WriteLine(candidate);
                            biggest = candidate;
                        }
                    }
                }
            }
            Console.WriteLine("Largest Prime Factor: " + biggest);
        }
    }
}
