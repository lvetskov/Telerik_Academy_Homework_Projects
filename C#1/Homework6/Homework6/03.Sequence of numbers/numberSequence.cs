using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sequence_of_numbers
{
    //Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

    class numberSequence
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter the number of ingeters: ");
            int nNumber = int.Parse(Console.ReadLine());
            int min = 0;
            int max = 0;
            for (int i = 1; i <= nNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine("The minimum number is: {0}", min);
            Console.WriteLine("The maximum number is: {0}", max);
        }
    }
}
