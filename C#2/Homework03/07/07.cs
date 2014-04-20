using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        //Write a method that reverses the digits of given decimal number. Example: 256  652
        static string Reverse(int number)
        {
            string numberInString = Convert.ToString(number);
            string reverseNumber = null;
            for (int i = 0; i < numberInString.Length; i++)
            {
                reverseNumber = numberInString[i] + reverseNumber;
            }
            return reverseNumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to reverse its digits:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Reverse(number));
        }
    }
}
