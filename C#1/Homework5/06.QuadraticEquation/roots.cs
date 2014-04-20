using System;

namespace _06.QuadraticEquation
{
    class roots
    {
        //Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

        static void Main()
        {
            Console.Write("Enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c:");
            int c = int.Parse(Console.ReadLine());
            if (a==0)
            {
                Console.WriteLine("The only root is: {0}", -(double)c/(double)b);
                Environment.Exit(0);
            }
            double det = b * b - 4 * a * c;
            det = Math.Sqrt(det);
            double rootOne = (-(double)b + det) / 2;
            Console.WriteLine("First root: {0}", rootOne);
            double rootTwo = (-(double)b - det) / 2;
            Console.WriteLine("Second root: {0}", rootTwo);
        }
    }
}
