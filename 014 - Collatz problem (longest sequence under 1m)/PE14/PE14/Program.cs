using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE14
{
    class Program
    {
        static void Main(string[] args)
        {
            int mainCount = 0;
            int number = 0;
            for (int i = 2; i < 1000000; i++)
            {
                long j = i;
                int count = 1;
                bool isOne = false;
                while (isOne == false)
                {
                    if (j % 2 == 0)
                    {
                        j = j / 2;
                        count++;
                        if (j == 1)
                        {
                            isOne = true;
                        }
                    }
                    else
                    {
                        j = 3 * j + 1;
                        count++;
                    }
                }
                if (count > mainCount)
                {
                    mainCount = count;
                    number = i;
                }
            }
            Console.WriteLine("Answer is: " + mainCount + " with the number: " + number);
            Console.ReadLine();
        }
    }
}
