using System;
using System.Collections.Generic;

class GenerateAllCombosDistinctElements
{
    static void Main()
    {
        //Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

        Console.Write("Enter wanted size of the subset: ");
        int variationsSizeK = int.Parse(Console.ReadLine());
        Console.Write("Enter array length: ");
        int arrayLengthN = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLengthN];

        //Fill the array with numbers from 1 to N
        for (int i = 0; i < arrayLengthN; i++)
        {
            array[i] = i + 1;
        }

        List<string> subsets = new List<string>();
        int maxSubset = (int)Math.Pow(2, arrayLengthN) - 1;
        for (int i = 1; i <= maxSubset; i++)
        {
            string iToBin = Convert.ToString(i, 2);
            int counter = 0;
            for (int index = 0; index < iToBin.Length; index++)
            {
                if (iToBin[index] == '1')
                {
                    counter++;
                }
            }

            if (counter == variationsSizeK)
            {
                string currentSubset = "";

                for (int j = 0; j <= arrayLengthN; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = mask & i;
                    if (nAndMask > 0)
                    {
                        currentSubset += array[j] + " ";
                        //currentSubset.Add(array[j]);
                    }
                }
                subsets.Add(currentSubset);
            }
        }

        subsets.Sort();
        Console.WriteLine(String.Join("\n", subsets));
    }
}