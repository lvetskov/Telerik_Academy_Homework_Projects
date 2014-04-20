using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    //Write a program that finds the maximal sequence of equal elements in an array.Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            Console.WriteLine("Input desired integer numbers. To exit the sequence press Enter");
		bool sequence = true;
		int value = 0;
		while(true)
		{
            sequence = int.TryParse(Console.ReadLine(), out value);
			if(sequence)
			{
				intList.Add(value);			
			}
			else
			{
				break;
			}

		}
		int[] array = new int[intList.Count]; //declarin an array for storing the number of repeating for the equal digits
        for (int i = 0; i < array.Length; i++)
        {
            array[i] += 1;
        }
		for(int i=0; i<intList.Count; i++)      //start checking for the longest continious row of equal digits
		{
            if (i>0)
            {
                if (intList[i-1] == intList[i])
                {
                    continue;
                }
            }
			for(int j=i+1; j<intList.Count; j++)
			{
				if(intList[i]==intList[j])
				{
					array[i] += 1;
					
				}
				else
				{
					break;
				}
			}
            
		}
        int max = array.Max();  //starting print sequence
        Console.Write("{ ");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                for (int j = 0; j < max; j++)
                {
                    Console.Write(intList[i] + " ");
                }
            }
        }
        Console.WriteLine("}");
        }
    }
}
