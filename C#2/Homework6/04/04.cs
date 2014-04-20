using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04
{
    //Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.

    class CompareLineByLine
    {
        static void Main(string[] args)
        {
            string fileNameOne = "test1.txt";
            string fileNameTwo = "test2.txt";
            StreamReader streamReaderOne = new StreamReader(fileNameOne);
            StreamReader streamReaderTwo = new StreamReader(fileNameTwo);
            string currentLineOne = null;
            string currentLineTwo = null;
            int numberOfSameLines = 0;
            int numberOfDifferentLines = 0;

            while (((currentLineOne = streamReaderOne.ReadLine()) != null) && ((currentLineTwo = streamReaderTwo.ReadLine()) != null))
            {
                if (currentLineOne == currentLineTwo)
                {
                    numberOfSameLines++;
                }
                else
                {
                    numberOfDifferentLines++;
                }

            }
            streamReaderOne.Close();
            streamReaderTwo.Close();
            Console.WriteLine("Number of same lines: {0}", numberOfSameLines);
            Console.WriteLine("Number of different lines: {0}", numberOfDifferentLines);
        }
    }
}
