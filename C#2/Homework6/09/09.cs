﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _09
{
    //Write a program that deletes from given text file all odd lines. The result should be in the same file.

    class DeletesOddLines
    {
        static void Main(string[] args)
        {
            string firstFileName = "test1.txt";
            EditFile(firstFileName);
        }

        private static void EditFile(string firstFileName)
        {
            List<string> fileInfo = new List<string>();
            using (StreamReader sourceFile = new StreamReader(firstFileName))
            {
                string line = sourceFile.ReadLine();
                int lineNumber = 1;
                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        fileInfo.Add(line);
                    }
                    line = sourceFile.ReadLine();
                    lineNumber++;
                }
            }

            using (StreamWriter destinationFile = new StreamWriter(firstFileName))
            {
                for (int i = 0; i < fileInfo.Count; i++)
                {
                    destinationFile.WriteLine(fileInfo[i]);
                }
            }
        }
    }
}
