using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public class HexadecimalToDecimal
    {
        //Write a program to convert hexadecimal numbers to their decimal representation.

        static int ConvertToDecimal(string numberInHexademial, int index = 0, int numberInDecimal = 0)
        {
            int testForParse = 0;
            if (index == numberInHexademial.Length)
            {
                return numberInDecimal;
            }
            if (Int32.TryParse((Convert.ToString(numberInHexademial[index])), out testForParse))
            {
                numberInDecimal += (int)(numberInHexademial[index] - 48) * (int)Math.Pow(16, numberInHexademial.Length - index - 1);
            }
            if (numberInHexademial[index] == 'A')
            {
                numberInDecimal += 10 * (int)Math.Pow(16, numberInHexademial.Length - index - 1);
            }
            if (numberInHexademial[index] == 'B')
            {
                numberInDecimal += 11 * (int)Math.Pow(16, numberInHexademial.Length - index - 1);
            }
            if (numberInHexademial[index] == 'C')
            {
                numberInDecimal += 12 * (int)Math.Pow(16, numberInHexademial.Length - index - 1);
            }
            if (numberInHexademial[index] == 'D')
            {
                numberInDecimal += 13 * (int)Math.Pow(16, numberInHexademial.Length - index - 1);
            }
            if (numberInHexademial[index] == 'E')
            {
                numberInDecimal += 14 * (int)Math.Pow(16, numberInHexademial.Length - index - 1);
            }
            if (numberInHexademial[index] == 'F')
            {
                numberInDecimal += 15 * (int)Math.Pow(16, numberInHexademial.Length - index - 1);
            }
            index++;
            return ConvertToDecimal(numberInHexademial, index, numberInDecimal);
        }
        public static void Main()
        {
            Console.WriteLine("Enter a hexademial number to convert to decimal. Note: The letters have to be capital!");
            string number = Console.ReadLine();
            Console.WriteLine(ConvertToDecimal(number));
        }
    }
}
