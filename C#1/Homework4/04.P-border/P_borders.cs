using System;

namespace _04.P_border
{
    class P_borders
    {
        //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

        static void Main()
        {
            Console.WriteLine("Enter left margin:");
            int left = int.Parse(Console.ReadLine());
            if (left <= 0)
            {
                Console.WriteLine("Enter Positive Value!!!");
                Environment.Exit(0);
            }
            Console.WriteLine("Enter right margin:");
            int right = int.Parse(Console.ReadLine());
            if (right <= 0)
            {
                Console.WriteLine("Enter Positive Value!!!");
                Environment.Exit(0);
            }
            int counter = 0;
            for (int i = left; i < right; i++)
            {
                if (i%5==0)
                {
                    counter++;
                }
                
            }
            Console.WriteLine("There are {0} integer numbers with reminder of division by 5 equals to zero, between {1} and {2}", counter, left, right);
        }
    }
}
