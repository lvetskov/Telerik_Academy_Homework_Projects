using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        //Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number K:");
            int k = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();
            Console.WriteLine("Input desired integer numbers. The number K must exist among the other numbers! To exit the sequence press Enter");
            bool sequence = true;
            int value = 0;
            while (true)
            {
                sequence = int.TryParse(Console.ReadLine(), out value);
                if (sequence)
                {
                    intList.Add(value);
                }
                else
                {
                    break;
                }
            }
            int[] arrayOfIntegers = intList.ToArray();
            Array.Sort(arrayOfIntegers);
            foreach (var number in arrayOfIntegers)
            {
                Console.WriteLine(number);
            }
            int index = Array.BinarySearch(arrayOfIntegers, k);
            Console.WriteLine("The largest number previous to K is: {0}", arrayOfIntegers[index-1]);
        }
    }
}
