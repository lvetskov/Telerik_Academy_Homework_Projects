using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    //Write a program that parses an URL address given in the format:

    class ParseURL
    {
        static void Main()
        {
            string str = @"http://www.devbg.org/forum/index.php";

            int index2Dots = 0;
            int index2Slash = 0;
            int index1Slash = 0;

            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 1) == ":")
                {
                    index2Dots = i;
                }
                else if ((str.Substring(i, 2) == "//"))
                {
                    index2Slash = i;
                    for (int k = i + 2; k < str.Length; k++)
                    {
                        if (str.Substring(k, 1) == "/")
                        {
                            index1Slash = k;
                            break;
                        }
                    }
                }
            }
            int protokolLength = index2Dots;
            int serverLength = index1Slash - index2Slash;
            int resourceLength = str.Length - 1 - index1Slash;

            string protokolStr = str.Substring(0, protokolLength);
            string serverStr = str.Substring(index2Slash + 1, serverLength);
            string resourceStr = str.Substring(index1Slash + 1, resourceLength);

            Console.WriteLine(@"[protokol] = ""{0}""", protokolStr);
            Console.WriteLine(@"[server] = ""{0}""", serverStr);
            Console.WriteLine(@"[resource] = ""{0}""", resourceStr);
        }
    }
}
