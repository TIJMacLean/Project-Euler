using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            int partialSumOfSquares = 0;
            int sumOfNumbers = 0;
            int partialSumOfNumbers = 0;
            int sumOfSquares = 0;
            int squareOfSum = 0;

            for (int i = number; i != 0; i--)
            {
                partialSumOfNumbers = partialSumOfNumbers + i;
            }
            sumOfNumbers = partialSumOfNumbers;
            squareOfSum = sumOfNumbers * sumOfNumbers;

            for (int i = number; i != 0; i--)
            {
                partialSumOfSquares = partialSumOfSquares + i * i;
            }
            sumOfSquares = partialSumOfSquares;

            Console.WriteLine(squareOfSum);
            Console.WriteLine(sumOfSquares);
            int answer = squareOfSum - sumOfSquares;
            Console.WriteLine(answer);
            Console.ReadLine();

        }
    }
}
