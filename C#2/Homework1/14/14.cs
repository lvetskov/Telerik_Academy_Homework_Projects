using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;



namespace _14
{
    //Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the strings for sorting:");
            List<string> stringList = new List<string>();
            Console.WriteLine("Input strings for sorting. To exit the sequence press Enter:");
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))                  //
                {                                                      //
                    break;                                             //check for a pressed enter and null value for the string -> terminating the .Add sequence
                }                                                      //
                stringList.Add(input);                         
            }
            var lengths = from element in stringList           //
                          orderby element.Length               //LINQ orderby keyword to sort a List by any property
                          select element;                      //
            foreach (string value in lengths)
            {
                Console.WriteLine(value);
            }
        }
    }
}