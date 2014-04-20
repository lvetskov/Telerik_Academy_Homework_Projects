using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        //Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.Use the method from the previous exercise.
        static int NumberForComparisson(params int[] elements)
        {
            for (int number = 0; number < elements.Length; number++)
            {
                if (number == 0)
                {
                    if (elements[number] > elements[number + 1])
                    {
                        return number;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (number == elements.Length)
                {
                    if (elements[number] > elements[number - 1])
                    {
                        return number;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (elements[number] > elements[number + 1] && elements[number] > elements[number - 1])
                {
                    return number;
                }
                else
                {
                    continue;
                }
            }
            return -1;

        }
        static void Main(string[] args)
        {
            //test case 1
            Console.WriteLine("The array is:");
            int[] givenArray = { 1, 1, 2, 3, 2, 3, 3, 3, 6, 5, 4, 6, 7, 7, 5, 8, 8, 1, 8, 9, 2, 9, 4, 1 };
            Console.Write(String.Join(", ", givenArray));
            Console.WriteLine();
            Console.WriteLine("The index is: {0}", NumberForComparisson(givenArray));
            Console.WriteLine();
            //test case2
            Console.WriteLine("The array is:");
            int[] givenArray2 = { 3, 1, 2 };
            Console.Write(String.Join(", ", givenArray2));
            Console.WriteLine();
            Console.WriteLine("The index is: {0}", NumberForComparisson(givenArray2));
            Console.WriteLine();
            //test case 3
            Console.WriteLine("The array is:");
            int[] givenArray3 = { 8, 8, 1, 8, 9, 2, 9, 4, 1 };
            Console.Write(String.Join(", ", givenArray3));
            Console.WriteLine();
            Console.WriteLine("The index is: {0}", NumberForComparisson(givenArray3));
            Console.WriteLine();
        }
    }
}
