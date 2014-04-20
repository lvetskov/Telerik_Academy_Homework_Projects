using System;
using System.Text;
using System.IO;

////Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace Homework03
{
    public static class _01
    {
        public static StringBuilder Substring(this StringBuilder stringbuilder, int startPosition)
        {
            if (stringbuilder.Length <= startPosition)
            {
                throw new IndexOutOfRangeException("Start index larger than the length of input string.");
            }
            StringBuilder resultStringBuilder = new StringBuilder();
            resultStringBuilder.Append(stringbuilder.ToString().Substring(startPosition));
        return resultStringBuilder;
        }
        public static StringBuilder Substring(this StringBuilder stringbuilder, int startPosition, int length)
        {
            if (stringbuilder.Length <= startPosition)
                throw new IndexOutOfRangeException("Start index larger than the length of input string.");
            if (stringbuilder.Length <= startPosition + length)
                throw new IndexOutOfRangeException("The length of the substring exceeds the characters of the StringBuilder after the start index.");
            StringBuilder resultStringBuilder = new StringBuilder();
            resultStringBuilder.Append(stringbuilder.ToString().Substring(startPosition, length));
            return resultStringBuilder;
        }
    }
}
