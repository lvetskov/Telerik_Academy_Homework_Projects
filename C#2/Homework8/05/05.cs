using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    //You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:

    class ToUpperCase
    {
        static string textResult;
        static string ChangeToUpper(string text)
        {
            string start = "<upcase>";
            string end = "</upcase>";
            int indexStart = 0;
            int indexEnd = 0;
            indexStart = text.IndexOf(start, indexStart);
            indexEnd = text.IndexOf(end, indexEnd);
            StringBuilder sb = new StringBuilder();
            sb.Append(text.Substring(0, indexStart));
            sb.Append(text.Substring(indexStart + start.Length, indexEnd - (indexStart + start.Length)).ToUpper());
            sb.Append(text.Substring(indexEnd + end.Length));
            text = text.Remove(indexEnd, end.Length);
            text = text.Remove(indexStart, start.Length);
            textResult = sb.ToString();
            if (text.IndexOf(start) != -1)
            {
                textResult = ChangeToUpper(sb.ToString());
            }
            return textResult;
        }
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine(ChangeToUpper(text));
        }
    }
}

