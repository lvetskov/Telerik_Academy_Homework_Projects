using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        //Write a program that finds the most frequent number in an array. Example:{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            Console.WriteLine("Input desired integer numbers. To exit the sequence press Enter");
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
            int[] arrayForCount = new int[intList.Count]; //declaring an array for storing the sum of all of the combinations
            for (int i = 0; i < intList.Count; i++)
            {
                for (int j = i; j < intList.Count; j++)
                {
                    if (intList[i] == intList[j])
                    {
                        arrayForCount[i]++;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < arrayForCount.Length; i++)
            {
                if (arrayForCount[i] == arrayForCount.Max())
                {
                    Console.WriteLine("{ " + intList[i] + " }, " + arrayForCount[i] + " times");
                }
                
            }

        }
    }
}
