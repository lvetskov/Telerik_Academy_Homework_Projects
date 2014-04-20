﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    //Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

    class PalidromesExtract
    {
        static void Main()
        {
            string text = @"Nice blue sky. No exe flying in the sky. ABBA will not come in Bulgaria.
       I don`t know what is lamal, maybe I will find some day. mouseesuom";
            char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
            string[] splitted = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);


            foreach (string word in splitted)
            {
                bool isPalindrome = true;
                for (int j = 0; j < (word.Length / 2); j++)
                {
                    if (word[j] != word[word.Length - 1 - j])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome && word.Length > 1)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
