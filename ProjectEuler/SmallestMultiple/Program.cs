using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            for (long i = 1; i < 99999999999999999; i++)
            {
                if (i % 20 == 0)
                    if (i % 19 == 0)
                        if (i % 18 == 0)
                            if (i % 17 == 0)
                                if (i % 16 == 0)
                                    if (i % 15 == 0)
                                        if (i % 14 == 0)
                                            if (i % 13 == 0)
                                                if (i % 12 == 0)
                                                    if (i % 11 == 0)
                                                        if (i % 10 == 0)
                                                            if (i % 9 == 0)
                                                                if (i % 8 == 0)
                                                                    if (i % 7 == 0)
                                                                        if (i % 6 == 0)
                                                                            if (i % 5 == 0)
                                                                                if (i % 4 == 0)
                                                                                    if (i % 3 == 0)
                                                                                        if (i % 2 == 0)
                                                                                        {
                                                                                            Console.WriteLine(i);
                                                                                            Console.ReadLine();
                                                                                        }
            }
        }
    }
}
