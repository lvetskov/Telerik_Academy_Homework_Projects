using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class BinaryToDecimal
    {
        //Write a program to convert binary numbers to their decimal representation.
        static int index = 0;
        static int ConvertToDecimal(string numberInBinary, int length, int numberInDecimal = 0)
        {
            if (length == 0)
            {
                return numberInDecimal;
            }
            numberInDecimal += Convert.ToInt32(numberInBinary[index] - 48) * (int)Math.Pow(2, length - 1);
            index++;
            length--;
            return ConvertToDecimal(numberInBinary, length, numberInDecimal);

        }
        public static void Main()
        {
            Console.WriteLine("Enter a binary number to convert to decimal");
            string number = Console.ReadLine();
            int numbersLength = number.Length;
            Console.WriteLine(ConvertToDecimal(number, numbersLength));
        }
    }
}
