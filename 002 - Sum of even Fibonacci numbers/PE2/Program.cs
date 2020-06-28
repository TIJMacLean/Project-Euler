using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE2
{
    class Program
    {
        static void Main(string[] args)
        {
            long total = 0;
            long working1 = 1;
            long working2 = 1;
            long temp = 0;
            long count = 0;
            Console.WriteLine("Please enter a number up to which the even Fibonacci numbers should be summed:");
            string numInput = Console.ReadLine();
            long num = Convert.ToInt64(numInput);

            while (working1 < num)
            {
                temp = working1;
                working1 = working1 + working2;
                working2 = temp;
                if (working1 % 2 == 0)
                {
                    total += working1;
                }
                count++;
            }

            Console.WriteLine("Total is: " + total);
            Console.Read();

        }
    }
}
