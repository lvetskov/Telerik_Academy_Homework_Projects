﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    //Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.

    class PadRight
    {
        static void Main()
        {
            Console.WriteLine("Enter text:");
            string str = Console.ReadLine();
            string newStr = str.PadRight(20, '*');
            Console.WriteLine(newStr);
        }
    }
}
