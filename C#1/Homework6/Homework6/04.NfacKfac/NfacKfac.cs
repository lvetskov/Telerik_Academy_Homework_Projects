using System;
using System.Numerics;
namespace _04.NfacKfac
{
    //Write a program that calculates N!/K! for given N and K (1<K<N).

    class NfacKfac
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K (K<N): ");
            int k = int.Parse(Console.ReadLine());
            BigInteger factorielN = 1;
            BigInteger factorielK = 1;
            if (k>=n)
            {
                Console.WriteLine("K must be lesser than N");
                Environment.Exit(0);
            }
            if (k==1 || n==1)
            {
                Console.WriteLine("K and N must be bigger than 1");
                Environment.Exit(0);
            }
            for (int i = 1; i <= k; i++)
            {
                factorielK *= i; 
            }
            for (int i = 1; i <= n; i++)
            {
                factorielN *= i; 
            }
            Console.WriteLine(factorielN/factorielK);
        }
    }
}
