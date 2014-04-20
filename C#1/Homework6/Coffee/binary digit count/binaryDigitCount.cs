using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_digit_count
{
    class binaryDigitCount
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            if (b != 0 && b != 1)
            {
                Environment.Exit(0);
            }
            int n = int.Parse(Console.ReadLine());
            if (n<1 || n>1000)
            {
                Environment.Exit(0); 
            }
            uint[] numbers = new uint[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = uint.Parse(Console.ReadLine());
                if (numbers[i] > 4000000000)
                {
                    Environment.Exit(0);
                }
            }
//----------------------------------------------------------------------------------
            string text;
            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 0;
                text = Convert.ToString(numbers[i], 2);
                for (int j = 0; j < text.Length; j++)
                {
                    if (b == (text[j]-'0'))
                    {
                        counter++;
                    }
                }
                Console.WriteLine(counter);
            }


        }
    }
}
