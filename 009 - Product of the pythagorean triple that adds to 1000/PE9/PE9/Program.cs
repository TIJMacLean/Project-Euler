using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int m = 1 ; m < 100 ; m++)
            {
                for (int n = 1 ; n < m ; n++)
                {
                    int a = m*m - n*n;
                    int b = 2*m*n;
                    int c = m*m + n*n;
                    if (a+b+c == 1000)
                    {
                        Console.WriteLine(a + " and " + b + " and " +c);
                        Console.WriteLine("So answer abc is: " + a * b * c);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
