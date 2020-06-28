using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PE18
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = File.ReadAllLines("./../../../PE18.txt")
                .Select(line => line.Split(" ".ToCharArray()))
                .ToArray();

            
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                {
                    arrg[i][j] = int.Parse(array[i][j]);

                }
            }

                string a = Console.Read().ToString();
                    
        }

    }
}
