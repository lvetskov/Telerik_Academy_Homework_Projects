using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    //Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
    class Program
    {
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
            int[] array = new int[intList.Count]; //declarin an array for storing the number of the increasing sequence
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1;
            }
            for (int i = 0; i < intList.Count; i++)      //start checking for the longest continious row of increasing digits
            {
                if (i > 0)
                {
                    if (intList[i - 1] == intList[i])
                    {
                        continue;
                    }
                }
                for (int j = i; j < intList.Count-1; j++)
                {
                    if (intList[j] < intList[j+1])
                    {
                        array[i] += 1;

                    }
                    else
                    {
                        break;
                    }
                }

            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            int max = array.Max();  //starting print sequence
            Console.WriteLine(max);
            Console.Write("{ ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    for (int j = i; j < max+i; j++)
                    {
                        Console.Write(intList[j] + " ");
                    }
                }
            }
            Console.WriteLine("}");
        }
    }
}
