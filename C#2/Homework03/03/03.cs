using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        //Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".
        static void NameOfLastDigit(string number)
        {
            int lastDigit = Convert.ToInt32(number)%10;
            switch (lastDigit)
            {
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                default: break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            string number = Console.ReadLine();
            NameOfLastDigit(number);
        }
    }
}
