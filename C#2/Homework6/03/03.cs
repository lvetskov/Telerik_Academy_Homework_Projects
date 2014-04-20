using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03
{
    //Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

    class InsertLineNumbers
    {
        static void Main(string[] args)
        {

            string fileName = "test.txt";
            StreamReader streamReader = new StreamReader(fileName);
            int n = 1;
            string line = null;
            string currentLine;
            while ((currentLine = streamReader.ReadLine()) != null)
            {
                line += Convert.ToString(n) + ". " + currentLine + "\n";
                n++;
            }
            Console.WriteLine(line);
            StreamWriter streamWriter = new StreamWriter("test_result.txt");
            using (streamWriter)
            {
                streamWriter.Write(line);
            }
        }
    }
}
