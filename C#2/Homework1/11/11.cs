using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        //Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

        static void Main(string[] args)
        {
            Console.WriteLine("Input the element for searching its index:");
            int element = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();
            Console.WriteLine("Input desired integer numbers. The array may not be sorted. To exit the sequence press Enter:");
            bool sequence = true;
            int value = 0;
            while (true)                                                          //
            {                                                                     //
                sequence = int.TryParse(Console.ReadLine(), out value);           //
                if (sequence)                                                     //
                {                                                                 //
                    intList.Add(value);                                           //
                }                                                                 //assinging values to the List
                else                                                              //
                {                                                                 //
                    break;                                                        //
                }                                                                 //
            }                                                                     //
            Console.WriteLine();
            Console.WriteLine("The array is sorted in ascending filter:");
            int count = intList.Count;                   //
            int[] array = new int[intList.Count];        //
            for (int i = 0; i < count; i++)              //
            {                                            //sorting the array
                array[i] = intList.Min();                //
                intList.Remove(intList.Min());           //
                Console.WriteLine(array[i]);             //
            }                                            //
            int start = 0;
            int middle = (array.Length+1)/2;
            int end = array.Length;
            if (element > array.Length)
            {
                    Console.WriteLine("There is no such element");
                    Environment.Exit(0);                
            }
            while (Math.Abs(start-end)!=1)      // Very important condition! :))
            {
                middle = (start + end + 1) / 2;
                if (array[middle] == element)
                {
                    Console.WriteLine();
                    Console.WriteLine("The element's index is:");
                    Console.WriteLine(middle);
                    Environment.Exit(0);
                }
                else if (array[middle] < element)
                {
                    start = middle;
                }
                else if (array[middle] > element)
                {
                    if (middle!=1)
                    {
                        end = middle;
                    }
                    else
                    {
                        end = 0;
                    }
                }
            }
            
        }
    }
}
