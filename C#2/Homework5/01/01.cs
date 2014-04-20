using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    //Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

    class CheckWhetherYearsIsLeap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year to be checked whether it is leap:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(year));
        }
    }
}
