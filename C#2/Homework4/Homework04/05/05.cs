using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class HexadecimalToBinary
    {
        // Write a program to convert hexadecimal numbers to binary numbers (directly).

        // GetNumber("F3", 0) -> 15, GetNumber("F3", 1) -> 3
        static int GetNumber(string s, int i)
        {
            if (s[i] >= 'A')
            {
                return s[i] - 'A' + 10;
            }
            else
            {
                return s[i] - '0';
            }
        }

        static string Base16ToBase2(string number)
        {
            string b = String.Empty;

            // Get each hex digit in base 2
            for (int i = number.Length - 1; i >= 0; i--)
            {
                for (int j = 0, d = GetNumber(number, i); j < 4; j++, d /= 2) // 2 ^ 4 = 16
                {
                    b = d % 2 + b;
                }
            }
            return b;
        }

        static void Main()
        {
            Console.WriteLine("Enter a hexademial number to convert to binary. Note: The letters have to be capital!");
            string number = Console.ReadLine();
            Console.WriteLine(Base16ToBase2(number));
        }
    }
}
