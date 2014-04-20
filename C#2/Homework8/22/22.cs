﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    //Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

    class DifferentWordCounter
    {
        static void Main()
        {
            Console.WriteLine("Insert a string");
            string str = Console.ReadLine();
            Dictionary<string, int> Words = new Dictionary<string, int>();
            var letters = new StringBuilder();
            foreach (var item in str.ToLower())
            {
                if (Char.IsLetter(item))
                {
                    letters.Append(item);
                }
                else if (letters.Length > 0)
                {
                    if (Words.ContainsKey(letters.ToString()))
                    {
                        Words[letters.ToString()]++;
                    }
                    else
                    {
                        Words.Add(letters.ToString(), 1);
                    }
                    letters.Clear();
                }
            }

            foreach (var item in Words)
            {
                Console.WriteLine("{0,-12} - {1,3} times found", item.Key, item.Value);
            }

            Console.WriteLine();
        }
    }
}
