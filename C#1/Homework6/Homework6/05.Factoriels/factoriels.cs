using System;
using System.Numerics;

namespace _05.Factoriels
{
    class factoriels
    {
        //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

        static void Main(string[] args)
        {
            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K (K>N): ");
            int k = int.Parse(Console.ReadLine());
            BigInteger factorielN = 1;
            BigInteger factorielK = 1;
            BigInteger factorielKN = 1;
            if (n >= k)
            {
                Console.WriteLine("N must be lesser than K");
                Environment.Exit(0);
            }
            if (k == 1 || n == 1)
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
            for (int i = 1; i <= (k-n); i++)
            {
                factorielKN *= i;
            }
            Console.WriteLine(factorielN * factorielK / factorielKN);
        }
    }
}
