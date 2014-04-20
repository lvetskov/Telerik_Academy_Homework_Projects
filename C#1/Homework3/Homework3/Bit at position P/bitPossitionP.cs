using System;

namespace Bit_at_position_P
{
    //Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.

    class bitPossitionP
    {
        static void Main()
        {
            Console.Write("Enter the number to be checked:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The decimal value of the number is: {0}", Convert.ToString(number, 2));
            Console.Write("Enter the bit possition to be checked:");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> p;
            Console.WriteLine("The bit is: {0}", bit);
            bool result = true;
            if (bit==1)
            {
                Console.WriteLine(result);
            }
            else
	         {
                 result = false;
                 Console.WriteLine(result);
	         }
        }
    }
}
