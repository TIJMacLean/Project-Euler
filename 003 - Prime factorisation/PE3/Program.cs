using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive integer to be factorised: ");
            string numInput = Console.ReadLine();
            long num = Convert.ToInt64(numInput);
            long[] pf = new long[100];
            pf[0] = 1;
            int count = 1;

            for (int i = 2; i < 100000; i++)
            {
                if (num % i == 0)
                {
                    pf[count] = i;
                    for (int j = 1; j <= count; j++)
                    {
                        if (i % pf[j] == 0)
                        {
                            if (j == count)
                            {
                                count++;
                            }
                            break;
                        }

                    }
                }
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("A prime factor is: " + pf[i]);
            }
            Console.WriteLine("A prime factor is: " + numInput);
            Console.ReadLine();
        }
    }
}
