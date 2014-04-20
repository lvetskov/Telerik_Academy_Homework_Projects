using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    //Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minimum of numbers:");
            CalcMinimum(8, 2, 14, 21, 30);
            Console.WriteLine("Maximum of numbers:");
            CalcMaximum(3, 91, 74, 55);
            Console.WriteLine("Average of numbers:");
            Avrg(8, 2, 5, 11);
            Console.WriteLine("Sum of numbers:");
            SumElements(3, 7, 10, 15);
            Console.WriteLine("Product of numbers:");
            MultiplyElements(4, 7, 16, 19);
        }

        static void CalcMinimum(params int[] elements)
        {
            int minimum = elements[0];
            foreach (int element in elements)
            {
                if (element < minimum)
                {
                    minimum = element;
                }
            }
            Console.WriteLine(minimum);
        }

        static void CalcMaximum(params int[] elements)
        {
            int maximum = elements[0];
            foreach (int element in elements)
            {
                if (element > maximum)
                {
                    maximum = element;
                }
            }
            Console.WriteLine(maximum);
        }

        static void Avrg(params decimal[] elements)
        {
            decimal average = 0;
            decimal sum = 0;
            foreach (int element in elements)
            {
                sum = sum + element;
                average = sum / elements.Length;
            }
            Console.WriteLine(average);
        }

        static void SumElements(params decimal[] elements)
        {
            int sum = 0;
            foreach (int element in elements)
            {
                sum = sum + element;
            }
            Console.WriteLine(sum);
        }

        static void MultiplyElements(params decimal[] elements)
        {
            int product = 1;
            foreach (int element in elements)
            {
                product = product * element;
            }
            Console.WriteLine(product);
        }
    }
}