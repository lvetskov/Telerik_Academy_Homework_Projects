using System;

namespace _02.Divide_by_5_and_7
{
    //Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

    class Division
    {
        static void Main()
        {
            Console.Write("Enter the number to be checked:");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("The number has to be other than zero");
                Environment.Exit(0); ;
            }
            int a = number % 5;
            int b = number % 7;
            if ((a==0) && (b==0))
            {
                Console.WriteLine("The number can be divided (without remainder) by 7 and 5 in the same time.");
            }
        }
    }
}
