using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        //Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.
        static void NumberOfOccurence(int number, params int[] elements)
        {
            int counter = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (number == elements[i])
                {
                    counter++;
                }
            }
            Console.WriteLine("The number {0} is met {1} times in the array!", number, counter);
        }

        static void Main(string[] args)
        {
            int[] givenArray = { 9, 1, 2, 3, 2, 3, 3, 3, 6, 5, 4, 6, 7, 7, 5, 8, 8, 1, 8, 9, 2, 9, 4, 1 };
            Console.WriteLine("Enter number from 1 to 9 to check its occurence in the array");
            int number = int.Parse(Console.ReadLine());
            NumberOfOccurence(number, givenArray);
        }
    }
}
