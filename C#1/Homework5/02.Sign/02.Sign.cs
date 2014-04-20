using System;

namespace _02.Sign
{
    class Program
    {
        //Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter first value:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third value:");
            double c = double.Parse(Console.ReadLine());
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Enter a non-zero value!!!");
                Environment.Exit(0);
            }
        
            if (a>0 && b>0 && c>0)
	            {
                    Console.WriteLine("+");
	            }
            else if (a>0 && b<0 && c>0)
            {
                Console.WriteLine("-");
            }
            else if (a>0 && b<0 && c<0)
            {
                Console.WriteLine("+");
            }
            else if (a>0 && b>0 && c<0)
            {
                Console.WriteLine("-");
            }


            if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b > 0 && c < 0)
            {
                Console.WriteLine("+");
            }
        }
    }
}
