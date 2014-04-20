using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10
{
    //Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

    class CalculateN
    {
        static void Main()
        {
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            CalculateFactorialOfN(arr);

        }
        static void CalculateFactorialOfN(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                BigInteger factorial = Factorial(i);
                Console.WriteLine(factorial);
            }
        }
        static BigInteger Factorial(int i)
        {
            BigInteger fact = i + 1;
            while (i > 0)
            {
                fact *= i;
                i--;
            }
            return fact;
        }
    }
}
