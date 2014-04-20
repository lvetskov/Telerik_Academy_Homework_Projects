using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort
{
    class sort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third value:");
            double c = double.Parse(Console.ReadLine());

            if (a >= b)
            {
                if (a >= c)
                {
                    if (b >= c)
                    {
                        Console.WriteLine("Descending order: {0} {1} {2}", a, b, c);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Descending order: {0} {1} {2}", a, c, b);
                        Environment.Exit(0);
                    }
                    
                }
                else
                {
                    Console.WriteLine("Descending order: {0} {1} {2}", c, a, b);
                    Environment.Exit(0);
                }
            }
            else if (c >= b)
            {
                Console.WriteLine("Descending order: {0} {1} {2}", c, b, a);
                Environment.Exit(0);                
            }
            else if (b >= c)
            {
                if (a >= c)
                {
                    Console.WriteLine("Descending order: {0} {1} {2}", b, a, c);
                    Environment.Exit(0);  
                }
                else
                {
                    Console.WriteLine("Descending order: {0} {1} {2}", b, c, a);
                    Environment.Exit(0);
                }
               
            }
        }
    }
}
