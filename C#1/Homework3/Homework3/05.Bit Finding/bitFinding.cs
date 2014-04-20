using System;

namespace _05.Bit_Finding
{
    //Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
    class bitFinding
    {
        static void Main()
        {
            Console.Write("Enter the number to be checked:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The decimal value of the number is: {0}", Convert.ToString(number, 2));
            int p = 2;
            int mask = 1 << p;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> p;
            Console.WriteLine("The bit is: {0}", bit);

        }
    }
}
