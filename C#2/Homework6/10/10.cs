using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _10
{
    //Write a program that extracts from given XML file all the text without the tags.
    class ExtractTextOutOfTags
    {
        static void Main(string[] args)
        {
            string firstFileName = "test1.txt";

            ReadFile(firstFileName);
        }

        private static void ReadFile(string firstFileName)
        {
            using (StreamReader sourceFile = new StreamReader(firstFileName))
            {
                string line = sourceFile.ReadLine();
                while (line != null)
                {
                    string pattern = ">[^<]*</";
                    string edited;
                    int length;
                    foreach (Match match in Regex.Matches(line, pattern))
                    {
                        edited = match.Value.ToString();
                        length = edited.Length;
                        edited = edited.Remove(length - 2, 2); //remove </
                        edited = edited.Remove(0, 1); //remove >
                        if (edited != null)
                        {
                            Console.WriteLine(edited);
                        }

                    }

                    line = sourceFile.ReadLine();
                }
            }
        }
    }
}
