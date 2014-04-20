using System;

namespace _13.Exchange_bits
{
    class exchangebits
    {
        static void Main()
        {
            Console.Write("Enter the number to be checked:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The decimal value of the number is: {0}", Convert.ToString(number, 2));
            //   Console.Write("Enter the bit possition to be checked:");
            //    int p = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            int numberAndMask = number & mask;
            int bit3 = numberAndMask >> 3;
            Console.WriteLine("The 3rd bit is: {0}", bit3);
            mask = 1 << 4;
            numberAndMask = number & mask;
            int bit4 = numberAndMask >> 4;
            Console.WriteLine("The 4th bit is: {0}", bit4);
            mask = 1 << 5;
            numberAndMask = number & mask;
            int bit5 = numberAndMask >> 5;
            Console.WriteLine("The 5th bit is: {0}", bit5);
            mask = 1 << 24;
            numberAndMask = number & mask;
            int bit24 = numberAndMask >> 24;
            Console.WriteLine("The 24th bit is: {0}", bit24);
            mask = 1 << 25;
            numberAndMask = number & mask;
            int bit25 = numberAndMask >> 25;
            Console.WriteLine("The 25th bit is: {0}", bit25);
            mask = 1 << 26;
            numberAndMask = number & mask;
            int bit26 = numberAndMask >> 26;
            Console.WriteLine("The 26th bit is: {0}", bit26);
            //-------------------------------------------------
            int v = bit24;
            int p = 3;
            mask = v << p;
            number = number & (~(1 << p));
            numberAndMask = number | mask;
            v = bit25;
            p = 4;
            mask = v << p;
            number = number & (~(1 << p));
            numberAndMask = number | mask;
            v = bit26;
            p = 5;
            mask = v << p;
            number = number & (~(1 << p));
            numberAndMask = number | mask;
            v = bit3;
            p = 24;
            mask = v << p;
            number = number & (~(1 << p));
            numberAndMask = number | mask;
            v = bit4;
            p = 25;
            mask = v << p;
            number = number & (~(1 << p));
            numberAndMask = number | mask;
            v = bit5;
            p = 26;
            mask = v << p;
            number = number & (~(1 << p));
            numberAndMask = number | mask;
            Console.WriteLine("The new number is: {0}", Convert.ToInt32(numberAndMask));
            Console.WriteLine("Decimal value of {0}", Convert.ToString(numberAndMask, 2));


        }
    }
}
