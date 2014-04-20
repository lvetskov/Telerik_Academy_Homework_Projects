using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _08
{
    //Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

    class ReplacingStartWithFinish
    {
        static void Main()
        {
            StreamReader read = new StreamReader("test1.txt");
            StreamWriter write = new StreamWriter("testresult.txt");
            string line = "";
            using (read)
            {
                using (write)
                {
                    line = read.ReadLine().ToLower();
                    while (line != null)
                    {
                        line = Regex.Replace(line, @"(\W|^)start(\W|$)", "$1finish$2");
                        write.WriteLine(line);
                        line = read.ReadLine();
                    }
                }
            }
        }
    }
}
