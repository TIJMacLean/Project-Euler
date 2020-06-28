using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 20;
            for (int i = 1;; i++)
            {
                for (int j = 1; j <= numbers; j++)
                {
                    if (i % j == 0)
                    {
                        if (j == numbers)
                        {
                            Console.WriteLine(i);
                            Console.ReadLine();
                        }
                    }
                    else
                    {   
                        break;
                    }
                }
            }

        }
    }
}
