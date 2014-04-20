using System;
using System.Numerics;
namespace _10.Catalan
{
    //In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:Write a program to calculate the Nth Catalan number by given N.


    class catalan
    {
        static void Main(string[] args)
        {
            BigInteger factorielN = 1;
            Console.WriteLine("Enter N: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("N has to be non-zero");
                Environment.Exit(0);
            }
            if (number <= 1)
            {
                Console.WriteLine("N has to be bigger than 1");
                Environment.Exit(0);
            }
            for (int i = 1; i <= number; i++)
            {
                factorielN *= i;
            }
     //       Console.WriteLine(factorielN);
            BigInteger factorielNPlusOne = 1;
            for (int i = 1; i <= (number+1); i++)
            {
                factorielNPlusOne *= i;
            }
       //     Console.WriteLine(factorielNPlusOne);
            BigInteger factorielNMultiplied2 = 1;
            for (int i = 1; i <= (number*2); i++)
            {
                factorielNMultiplied2 *= i;
            }
        //    Console.WriteLine(factorielNMultiplied2);
            Console.WriteLine(factorielNMultiplied2 / (factorielNPlusOne *factorielN));
        }
    }
}
