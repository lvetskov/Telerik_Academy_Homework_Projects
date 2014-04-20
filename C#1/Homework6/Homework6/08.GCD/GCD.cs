using System;

namespace _08.GCD
{
    //Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

    class GCD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int second = int.Parse(Console.ReadLine());
            while (first!=second)
            {
                if (first>second)
                {
                    first -= second;
                }
                else
                {
                    second -= first;
                }
            }
            Console.WriteLine("The gratest common divisor is: {0}", first );
        }
    }
}
