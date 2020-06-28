using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE10
{
    class Program
    {
        static void Main(string[] args)
        {
            long working = 5;
            Console.WriteLine("How many primes numbers would you like (more than 1)? ");
            string upToString = Console.ReadLine();
            int upTo = Int32.Parse(upToString);
            Console.WriteLine('\n' + "Your " + upToString + " prime numbers are: ");

            int checkTo = (int)Math.Sqrt(upTo);
            int[] checks = new int[checkTo];
            int[] primes = new int[upTo];
            primes[0] = 2;
            primes[1] = 3;

            for (int i = 1; i <= checkTo; i++)
            {
                checks[i - 1] = i;
            }

            bool mark = false;
            int counter = 2;
            for (int i = 2; primes[upTo - 1] == 0; i++)
            {
                if (primes[counter-1] > 2000000)
                {
                    Console.WriteLine("And the total is: " + (working-primes[counter-1]));
                    Console.ReadLine();
                }
                else
                {
                    for (int j = 2; j <= (int)Math.Sqrt(i); j++)
                    {
                        if (i % j == 0 && i != j)
                        {
                            mark = false;
                            break;
                        }
                        else
                        {
                            mark = true;
                        }
                    }
                    if (mark == true)
                    {
                        primes[counter] = i;
                        counter++;
                        working = working + i;
                    }
                }
            }
            for (int i = 0; i < upTo; i++)
            {
                Console.WriteLine(primes[i]);
            }
            Console.ReadLine();   
        }
    }
}
