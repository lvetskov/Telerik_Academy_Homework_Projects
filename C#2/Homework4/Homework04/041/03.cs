using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    public class DecimalToHexadecimal
    {
        //Write a program to convert decimal numbers to their binary representation.
        static int rest = 1;
        static string numberInBinary;
        static string ConvertToBinary(int numberInDecimal)
        {
            if (numberInDecimal == 0)
            {
                string reverseNumberInBinary = null;
                for (int i = 0; i < numberInBinary.Length; i++)
                {
                    reverseNumberInBinary += numberInBinary[numberInBinary.Length - i - 1];
                }
                return reverseNumberInBinary;
            }
            rest = numberInDecimal % 16;
            numberInDecimal = numberInDecimal / 16;
            if (rest == 10)
            {
                numberInBinary += "A";
            }
            else if (rest == 11)
            {
                numberInBinary += "B";
            }
            else if (rest == 12)
            {
                numberInBinary += "C";
            }
            else if (rest == 13)
            {
                numberInBinary += "D";
            }
            else if (rest == 14)
            {
                numberInBinary += "E";
            }
            else if (rest == 15)
            {
                numberInBinary += "F";
            }
            else
            {
                numberInBinary += Convert.ToString(rest);
            }
            return ConvertToBinary(numberInDecimal);

        }
        public static void Main()
        {
            Console.WriteLine("Enter a decimal number to convert to hexadecimal");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertToBinary(number));
        }
    }
}
