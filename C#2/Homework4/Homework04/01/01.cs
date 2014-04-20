using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class DecimalToBinary
    {
        //Write a program to convert decimal numbers to their binary representation.
        static int rest = 1;
        static int counter = 1;
        static int ConvertToBinary(int numberInDecimal, int numberInBinary = 0)
        {
            if (numberInDecimal == 0)
            {
                return numberInBinary;
            }
            rest = numberInDecimal % 2;
            numberInDecimal = numberInDecimal / 2;
            numberInBinary = numberInBinary + rest * counter;
            counter *= 10;
            return ConvertToBinary(numberInDecimal, numberInBinary);

        }
        public static void Main()
        {
            Console.WriteLine("Enter a decimal number to convert to binary");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertToBinary(number));
        }
    }
}