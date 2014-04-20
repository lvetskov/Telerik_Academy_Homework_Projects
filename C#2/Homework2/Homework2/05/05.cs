using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        //You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

        static void Main(string[] args)
        {
            Console.WriteLine("Input the strings for sorting:");
            List<string> matrix = new List<string>();
            Console.WriteLine("Input strings for sorting. To exit the sequence press Enter:");
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))                  //
                {                                                      //
                    break;                                             //check for a pressed enter and null value for the string -> terminating the .Add sequence
                }                                                      //
                matrix.Add(input);
            }
            string[] sortedMatrix = new string[matrix.Count];
            List<int> lenghtOfStringsInMatrix = new List<int>();            //creating a list with the same count as the string list, but containing the number of symbols in each string
            for (int count = 0; count < matrix.Count; count++)               //
            {                                                                //assinging those values
                lenghtOfStringsInMatrix.Add(matrix[count].Length);           //
            }                                                                //
            int maxCount = matrix.Count;
            int indexForSortedMatrix = matrix.Count;
            for (int i = 0; i < maxCount; i++)
            {
                int maxLength = 0;
                int maxPositionInMatrix = 0;
                for (int position = 0; position < lenghtOfStringsInMatrix.Count; position++)        //
                {                                                                                   //
                    if (lenghtOfStringsInMatrix[position] >= maxLength)                             //
                    {                                                                               //finding the greates string lenght and removes it
                        maxLength = lenghtOfStringsInMatrix[position];                              //
                        maxPositionInMatrix = position;                                             //
                    }                                                                               //
                }                                                                                   //
        //        Console.WriteLine(lenghtOfStringsInMatrix[maxPositionInMatrix]);                  //
        //        Console.WriteLine(maxPositionInMatrix);                                           //
        //        Console.WriteLine();                                                              //
                sortedMatrix[indexForSortedMatrix - 1] = matrix[maxPositionInMatrix];               //
                indexForSortedMatrix--;                                                             //
                lenghtOfStringsInMatrix.RemoveAt(maxPositionInMatrix);                              //
                matrix.RemoveAt(maxPositionInMatrix);                                               //
            }
            Console.WriteLine("The sorted matrix looks like:");
            foreach (var item in sortedMatrix)
            {
                Console.WriteLine(item);
            }
        }
    }
}
