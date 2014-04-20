using System;

namespace Homework3
{
    //Write an expression that checks if given integer is odd or even.

    class IntegerCheck
    {
        static void Main()
        {
            Console.Write("Enter the number to be checked:");
            int number = int.Parse(Console.ReadLine());
            if (number==0)
            {
                Console.WriteLine("The number has to be other than zero");
                Environment.Exit(0); ;
            }
            double check = (double)number % 2;
            if ((check == 0) && (number!=0))
            {
                Console.WriteLine("The number is even!");
            }
            else
                Console.WriteLine("The number is odd!");

        }
    }
}
