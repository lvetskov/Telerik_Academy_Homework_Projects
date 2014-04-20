using System;

namespace _01.Print_Numbers
{
    //Write a program that prints all the numbers from 1 to N.

    class printNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
