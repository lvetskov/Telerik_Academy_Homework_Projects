using System;

namespace _07.Prime_Number
{
    //Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

    class primeNumber
    {
        static void Main()
        {
            Console.Write("Enter the number to be checked:");
            int number = int.Parse(Console.ReadLine());
            if (number>100)
            {
                Console.WriteLine("The number has to be lesser than 100");
                Environment.Exit(0);
            }
            int help;
            bool result = true;
            for (int i = 2; i < (number-1); i++)
            {

                if (true)
                {
                    help = number % i;
                    if (help == 0)
                    {
                        result = false;
                    }
                }
            }
            if (result)
            {
                Console.WriteLine("The number is Prime!");  
            }
            else
            {
                Console.WriteLine("The number is not Prime!");  
            }
        }
    }
}
