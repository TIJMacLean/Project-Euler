using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE12
{
    class Program
    {
        static void Main(string[] args)
        {
            int toAdd = 2;
            int triangleNumber = 1;
            int[] divisors = new int[1000];

            while (divisors[500] == 0)
            {
                triangleNumber = triangleNumber + toAdd;
                toAdd++;
                int j = 0;
                for (int i = 1; i <= triangleNumber / 2; i++)
                {
                    if (triangleNumber % i == 0)
                    {
                        divisors[j] = i;
                        j++;
                    }
                }
                divisors[j] = triangleNumber;
            }

            Console.WriteLine("Answer is " + triangleNumber);
            Console.ReadLine();
        }
    }
}
