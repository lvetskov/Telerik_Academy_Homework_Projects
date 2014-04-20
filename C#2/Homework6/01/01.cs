using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01
{
    //Write a program that reads a text file and prints on the console its odd lines.

    class PrintOddLineContent
    {
        static void Main(string[] args)
        {
            int n = 1;
            string fileName = "test.txt";
            StreamReader streamReader = new StreamReader(fileName);
            for (string line; (line = streamReader.ReadLine()) != null; n++)
            {
                if (n % 2 == 1) Console.WriteLine(line);
            }
            streamReader.Close();
        }
    }
}
