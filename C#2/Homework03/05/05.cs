using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        //Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
        static void NumberForComparisson(params int[] elements)
        {
            Console.WriteLine("Enter number from 1 to 21 to check its neighbring elements: ");
            int number = int.Parse(Console.ReadLine());
            if (elements[number] > elements[number - 1] && elements[number] > elements[number + 1])
            {
                Console.WriteLine("The number {0} is bigger than both of its neighbours!", elements[number]);
            }
            else
            {
                Console.WriteLine("The number {0} is not bigger than its neighbours!", elements[number]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The array is:");
            int[] givenArray = { 9, 1, 2, 3, 2, 3, 3, 3, 6, 5, 4, 6, 7, 7, 5, 8, 8, 1, 8, 9, 2, 9, 4, 1 };
            Console.Write(String.Join(", ", givenArray));
            Console.WriteLine();
            NumberForComparisson(givenArray);
        }
    }
}
