using System;
namespace GreatestOfFive
{
    class biggestOfFive
    {
        //Write a program that finds the greatest of given 5 variables.


        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third value:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter forth value:");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter fifth value:");
            double e = double.Parse(Console.ReadLine());

            if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
            {
                Console.WriteLine("The greater number is: {0}", a);
            }
            if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
            {
                Console.WriteLine("The greater number is: {0}", b);
            }
            if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
            {
                Console.WriteLine("The greater number is: {0}", c);
            }
            if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
            {
                Console.WriteLine("The greater number is: {0}", d);
            }
            if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
            {
                Console.WriteLine("The greater number is: {0}", e);
            }
        }
    }
}
