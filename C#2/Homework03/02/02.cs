using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        //Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
        static int GetMax(int one, int two, int three)
        {
            if (one>two && one>three)
            {
                return (one);
            }
            else if (two>one && two>three)
            {
                return (two);
            }
            else
            {
                return (three);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 integer numers:");
            int fistInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            Console.WriteLine("The maximum number is: {0}", GetMax(fistInt, secondInt, thirdInt));
        }
    }
}
