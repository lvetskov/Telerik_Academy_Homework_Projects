using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06
{
    class WriteFileWithNamesAndSortThem
    {
        static void Main()
        {
            string filename = "test1.txt";
            StreamReader sr = new StreamReader(filename);
            string row = "";
            List<string> rows = new List<string>();
            while (row != null)
            {
                row = sr.ReadLine();
                if (row != null)
                {
                    rows.Add(row);
                }
            }
            sr.Close();
            rows.Sort();
            string outputfile = "resultfile.txt";
            StreamWriter sw = new StreamWriter(outputfile, false);
            for (int i = 0; i < rows.Count; i++)
            {
                sw.WriteLine(rows[i]);
            }
            sw.Close();
        }
    }
}
