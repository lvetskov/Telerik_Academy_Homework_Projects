using System;

namespace _12.NVP
{
    //We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.

    class bitinsertion
    {
        static void Main()
        {
            Console.Write("Enter the number n:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The decimal value of the number is: {0}", Convert.ToString(number, 2));
            Console.Write("Enter the bit value v:");
            int v = int.Parse(Console.ReadLine());
            Console.Write("Enter the bit possition p:");
            int p = int.Parse(Console.ReadLine());
            int mask = v << p;
      //      Console.WriteLine(mask);
            number = number & (~(1 << p));
            int numberAndMask = number | mask;
            Console.WriteLine("The new number is: {0}", Convert.ToInt32(numberAndMask));
            Console.WriteLine("Decimal value of {0}", Convert.ToString(numberAndMask, 2));
        }
    }
}
