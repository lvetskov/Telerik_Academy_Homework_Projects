using System;

namespace Homework4
{
    class threeintegersum
    {
        //Write a program that reads 3 integer numbers from the console and prints their sum.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers:");
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int sum = one + two + three;
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
