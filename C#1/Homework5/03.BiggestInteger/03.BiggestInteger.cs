using System;
namespace _03.BiggestInteger
{
    class Program
    {
        //Write a program that finds the biggest of three integers using nested if statements.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third value:");
            double c = double.Parse(Console.ReadLine());

            if (a>b)
            {
                if (b>c)
                {
                    Console.WriteLine("The biggest number is: {0}", a);
                }
                else if (a>c)
                {
                    Console.WriteLine("The biggest number is: {0}", a);
                }
                else
                {
                    Console.WriteLine("The biggest number is: {0}", c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("The biggest number is: {0}", b);
                }
                else if (b < c)
                {
                    Console.WriteLine("The biggest number is: {0}", c);
                }
            }
        }
    }
}
