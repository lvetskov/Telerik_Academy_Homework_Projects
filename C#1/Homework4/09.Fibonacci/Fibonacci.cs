using System;

namespace _09.Fibonacci
{
    //Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fibonacci end number:");
            int fibonacci = int.Parse(Console.ReadLine());
            ulong[] array = new ulong[102];
            array[0] = 0;
            array[1] = 1;
            for (int i = 1; i <= fibonacci; i++)
            {
                Console.WriteLine(array[i]);
                array[i + 1] = array[i] + array[i - 1];
            }

        }

    }
}
