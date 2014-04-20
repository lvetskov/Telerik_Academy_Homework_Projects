using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    //Write a program that prints to the console which day of the week is today. Use System.DateTime.
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today is:" + DateTime.Today.DayOfWeek);
        }
    }
}
