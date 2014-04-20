using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fibonacci
{
    //Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

    class fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fibonacci end number:");
            int fibonacci = int.Parse(Console.ReadLine());
            ulong[] array = new ulong[102];
            array[0] = 0;
            array[1] = 1;
            ulong sum = 0;
            for (int i = 1; i <= fibonacci; i++)
            {
                Console.WriteLine(array[i]);
                sum += array[i];
                array[i + 1] = array[i] + array[i - 1];
            }
            Console.WriteLine("The sum is: {0}",sum);

        }
    }
}
