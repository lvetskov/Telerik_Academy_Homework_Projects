using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02
{
    //Write a program that concatenates two text files into another text file.

    class concatenatesTwoTextFiles
    {
        static void Main(string[] args)
        {
            string fileNameOne = "test1.txt";
            string fileNameTwo = "test2.txt";
            string fileOneContent;
            string fileTwoContent;
            StreamReader streamReaderOne = new StreamReader(fileNameOne);
            StreamReader streamReaderTwo = new StreamReader(fileNameTwo);
            using (streamReaderOne)
            {
                fileOneContent = streamReaderOne.ReadToEnd();
            }
            using (streamReaderTwo)
            {
                fileTwoContent = streamReaderTwo.ReadToEnd();
            }
            Console.WriteLine(fileOneContent + "\n" + fileTwoContent);
            StreamWriter streamWriter = new StreamWriter("test_result.txt");
            using (streamWriter)
            {
                streamWriter.WriteLine(fileOneContent + "\n" + fileTwoContent);
            }
        }
    }
}
