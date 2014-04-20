using System;

namespace ValueOfBit
{
    //Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.


    class valueofbit
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
            
        }
    }
}
