using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE4
{
    class Program
    {
        static void Main(string[] args)
        {
            int answerfinal = 1;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int ij = i * j;
                    string sij = ij.ToString();
                    char[] aij = sij.ToCharArray();
                    int digits = aij.Length;
                    char[] bij = new char[digits];
                    for (int k = 0; k < digits; k++)
                    {
                        bij[k] = aij[digits - k - 1];
                    }
                    string saij = new string(aij);
                    string sbij = new string(bij);
                    if (saij == sbij)
                    {
                        int answer1 = ij;
                        if (answer1 > answerfinal)
                        {
                            answerfinal = answer1;
                        }
                    }
                }
            }
            Console.WriteLine(answerfinal);
            Console.ReadLine();
        }
    }
}
