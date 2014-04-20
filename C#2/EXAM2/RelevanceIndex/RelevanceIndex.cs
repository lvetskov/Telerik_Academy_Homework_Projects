using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevanceIndex
{
    class RelevanceIndex
    {
        static void Main(string[] args)
        {
            string searchWord = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            string[] text = new string[rows];
            for (int i = 0; i < rows; i++)
            {
                text[i] = Console.ReadLine();
            }
            for (int i = 0; i < rows; i++)
            {
                string[] split = text[i].Split(new[] { ',', '.', '(', ')', ';', '-', '!', '?', ' '}, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < split.Length; j++)
                {
                    sb.Append(split[j]);
                    if (j == split.Length -1)
                    {
                        break;
                    }
                    sb.Append(" ");
                }
                text[i] = sb.ToString();
            }
            Console.WriteLine();
            int[] relevance = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                relevance[i] = 0;
                text[i] = text[i].ToLower();
                string currentString = text[i];
                for (int j = 0; j < text[i].Length - searchWord.Length; j++)
                {
                    int first = currentString.IndexOf(searchWord);
                    if (first == -1)
                    {
                        break;
                    }
                    currentString = currentString.Remove(first, searchWord.Length);
                    relevance[i]++;
                }
                text[i] = text[i].Replace(searchWord, searchWord.ToUpper());
            }
            for (int j = 0; j < relevance.Length; j++)
            {
                int maxValue = relevance.Max();
                for (int i = 0; i < relevance.Length; i++)
                {
                    if (maxValue == relevance[i])
                    {
                        Console.WriteLine(text[i]);
                        relevance[i] = -1;
                        break;
                    }
                }

            }
        }
    }
}
