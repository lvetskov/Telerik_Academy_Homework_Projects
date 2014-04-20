using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        //Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
        static void Main(string[] args)
        {
            Console.WriteLine("Input the sum for checking:");
            int sumForCheck = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();
            Console.WriteLine("Input desired integer numbers. To exit the sequence press Enter:");
            bool sequence = true;
            int value = 0;
            while (true)
            {                                                                //
                sequence = int.TryParse(Console.ReadLine(), out value);      //
                if (sequence)                                                //
                {                                                            //
                    intList.Add(value);                                      //
                }                                                            //assigning values to the List
                else                                                         //
                {                                                            //
                    break;                                                   //
                }                                                            //
            }                                                                //
            int sizeOfArray = 0;//defining the size of the array with possible combos;
            for (int i = 0; i < intList.Count; i++)
            {
                sizeOfArray += (intList.Count - 1 - i);
            }
            int[] arrayForSums = new int[sizeOfArray]; //declaring an array for storing the sum of all of the combinations
            string[] result = new string[sizeOfArray]; //declaring an array for storing the row of numbers of all of the combinations as strings
            int counter = 0;
            for (int k = 0; k < intList.Count - 1; k++)   //starting the loop sequences
            {
                for (int i = intList.Count - 1; i > k; i--)
                {
                    int sum = 0;
                    bool sign = false;
                    for (int combo = k; combo <= i; combo++)
                    {
                        if (sign)                                        //
                        {                                                //
                            if (combo <= i)                              //
                            {                                            //
                                if (intList[combo] >= 0)                 //determine the sign
                                {                                        //
                                    result[counter] += "+";              //
                                }                                        //
                            }                                            //
                        }                                                //
                        result[counter] += Convert.ToString(intList[combo]);
                        if (combo == i)
                        {
                            result[counter] += " =";
                        }
                        sum += intList[combo];
                        sign = true;
                    }
                    arrayForSums[counter] = sum;
                    counter++;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < sizeOfArray; i++)
            {
                if (arrayForSums[i] == sumForCheck)
                {
                    Console.WriteLine("The greatest sum is: {0}", result[i] + " " + arrayForSums[i]);
                }
            }
        }
    }
}
