using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingLetters
{
    class MovingLetters
    {
        static void Main(string[] args)
        {
            StringBuilder resultOfExtarcting = new StringBuilder();
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            long maxLength = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxLength)
                {
                    maxLength = words[i].Length;
                }
            }
            for (int j = 0; j < maxLength; j++)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (string.IsNullOrEmpty(words[i]))
                    {
                        continue;
                    }
                    resultOfExtarcting.Append(words[i][words[i].Length - 1]);
                    words[i] = words[i].Remove(words[i].Length - 1);
                }
            }

            string resultInString = resultOfExtarcting.ToString();
            for (int position = 0; position < resultInString.Length; position++)
            {
                
                char currentChar = resultInString[position];
                int numberInAlphabet = Char.ToLower(currentChar) - 96;
                int newPosition = numberInAlphabet;
                int currentLength = resultInString.Length;
                if ((newPosition) % currentLength == 0)
                {
                    continue;
                }
                int move = newPosition;
                if (newPosition > resultInString.Length - position)
                {
                    while (move > resultInString.Length)
                    {
                        move = newPosition % resultInString.Length;
                    }
                }
                
                resultInString = resultInString.Insert(move + 1, currentChar.ToString());
                if (newPosition < move + 1)
                {
                    resultInString = resultInString.Remove(position + 1, 1);
                }
                else
                {
                    resultInString = resultInString.Remove(position, 1);
                }


            }
            Console.WriteLine(resultInString);
        }
    }
}
