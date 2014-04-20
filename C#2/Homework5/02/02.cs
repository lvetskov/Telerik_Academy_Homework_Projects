using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    //Write a program that generates and prints to the console 10 random values in the range [100, 200].

    class TenRandomValues
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 random values in range [100,200]:");
            Random randomGenerator = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randomGenerator.Next(100, 200));
            }
        }
    }
}