using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    //Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.

    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int n = 0;
            bool invalid = false;
            Console.Write("Enter number N = ");
            invalid = int.TryParse(Console.ReadLine(), out n);
            if (!invalid)
            {
                Console.WriteLine("Enter correct value!!!");
                Environment.Exit(0);
            }
            Console.Write("Enter number K = ");
            invalid = int.TryParse(Console.ReadLine(), out k);
            if (!invalid)
            {
                Console.WriteLine("Enter correct value!!!");
                Environment.Exit(0);
            }
            if (k >= n)
            {
                Console.WriteLine("K has to be lesser than N!!!");
                Environment.Exit(0);
            }
            int[] nArray = new int[n];
            int[] kArray = new int[k];
            for (int i = 0; i < n; i++)
            {
                invalid = int.TryParse(Console.ReadLine(), out nArray[i]);
                if (!invalid)
                {
                    Console.WriteLine("Enter correct value!!!");
                    Environment.Exit(0);
                }
            }

            int counter = 0;
            for (int i = 0; i < nArray.Length; i++)     //Loop for finding the max value of nArray, assign it to kArray, and then deletes it, K times
            {
                while (counter <= k-1)
                {
                    kArray[counter] = nArray.Max();

                    for (int j = 0; j < nArray.Length; j++)
                    {
                        if (nArray[j] == nArray.Max())
                        {
                            nArray[j] = 0;
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine("The K numbers with maximum sum are:");
            foreach (var number in kArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("= " + kArray.Sum());
        }
    }
}
