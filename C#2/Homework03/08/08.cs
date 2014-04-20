using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        //Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
        static void LongNumbers(string numberOne, string numberTwo)
        {
            //adding zeros to the shorter number to match the number of digits in the other (longer) number
            if (numberOne.Length != numberTwo.Length)
            {
                if (numberOne.Length > numberTwo.Length)
                {
                    numberTwo = numberTwo.PadLeft(numberOne.Length, '0');
                }
                else
                {
                    numberOne = numberOne.PadLeft(numberTwo.Length, '0');
                }
            }
            Console.WriteLine("The numbers with equal digit number:");
            Console.WriteLine(numberOne);
            Console.WriteLine(numberTwo);
            //transfering the strings to lists
            List<char> charListNumberOne = new List<char>();
            foreach (var character in numberOne)
            {
                charListNumberOne.Add(character);
            }

            List<char> charListNumberTwo = new List<char>();
            foreach (var character in numberTwo)
            {
                charListNumberTwo.Add(character);
            }
            byte[] byteSumTotal = new byte[charListNumberTwo.Count];
            byte oneForNextRound = 0;
            for (int i = charListNumberTwo.Count - 1; i >= 0; i--)
            {
                int currentSum = 0;
                currentSum = (byte)charListNumberOne[i] - 48 + (byte)charListNumberTwo[i] - 48 + oneForNextRound;
                if (currentSum >= 10)
                {
                    currentSum = currentSum % 10;
                    oneForNextRound = 1;
                    byteSumTotal[i] = (byte)currentSum;
                }
                else
                {
                    oneForNextRound = 0;
                    byteSumTotal[i] = (byte)currentSum;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The resultlt is:");
            foreach (var item in byteSumTotal)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first positive number: ");
            string numberOne = Console.ReadLine();
            Console.WriteLine("Enter second positive number: ");
            string numberTwo = Console.ReadLine();
            Console.WriteLine();
            LongNumbers(numberOne, numberTwo);
        }
    }
}
