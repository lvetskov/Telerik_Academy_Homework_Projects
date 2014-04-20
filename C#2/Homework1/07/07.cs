using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool invalid = false;
            Console.Write("Enter number N = ");
            invalid = int.TryParse(Console.ReadLine(), out n);
            if (!invalid)
            {
                Console.WriteLine("Enter correct value!!!");
                Environment.Exit(0);
            }
            int[] nArray = new int[n];
            int[] sortedArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                invalid = int.TryParse(Console.ReadLine(), out nArray[i]);
                if (!invalid)
                {
                    Console.WriteLine("Enter correct value!!!");
                    Environment.Exit(0);
                }
            }
            for (int i = 0; i < n; i++)
            {
                sortedArray[i] = nArray.Min();
                for (int j = 0; j < n; j++)
                {
                    if (nArray[j] == nArray.Min())
                    {
                        nArray[j] = Int32.MaxValue;
                        break;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
