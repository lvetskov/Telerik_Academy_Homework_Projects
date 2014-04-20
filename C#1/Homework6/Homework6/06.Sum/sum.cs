using System;
using System.Numerics;
namespace _06.Sum
{
    class sum
    {
        //Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

        static void Main(string[] args)
        {
            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X: ");
            int x = int.Parse(Console.ReadLine());
            BigInteger factorielN = 1;
            decimal sum = 1M; 
            if (x==0)
            {
                Console.WriteLine("X has to be non-zero");
                Environment.Exit(0);
            }
            if (n<=1)
            {
                Console.WriteLine("N has to be bigger than 1");
                Environment.Exit(0);
            }

            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
                sum += ((decimal)factorielN) / ((decimal)(Math.Pow(x, i)));
            }

            Console.WriteLine(sum);
        }
    }
}
