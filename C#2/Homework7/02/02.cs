using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    //Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
    //If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
    //		a1, a2, … a10, such that 1 < a1 < … < a10 < 100

    class MethodReadNumber
    {
        static int ReadNumber(int start, int end)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (!(start < n && n < end))
                {
                    throw new ArgumentOutOfRangeException();
                }
                return n;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter 10 numbers from 1 to 100 in increasing order");
            int min = 1, max = 100;

            for (int i = 0; i < 10; i++)
            {
                min = ReadNumber(min, max);
            }
        }
    }
}
