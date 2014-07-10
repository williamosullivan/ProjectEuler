using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquares = 0;
            int sumOfNaturals = 0;
            for (int i = 100; i > 0; i--)
            {
                sumOfSquares += (i ^ 2);
            }
            for (int i=100; i > 0; i--)
            {
                sumOfNaturals += i;
            }
            Console.WriteLine(sumOfSquares);
            sumOfNaturals = sumOfNaturals * sumOfNaturals;
            Console.WriteLine(sumOfNaturals);
            Console.WriteLine("Difference: " + (sumOfSquares - sumOfNaturals));
            Console.ReadLine();
        }
    }
}
