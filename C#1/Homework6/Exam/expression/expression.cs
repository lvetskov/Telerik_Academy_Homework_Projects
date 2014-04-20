using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expression
{
    class expression
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            double sum = 0;
            if (text[0]=='-')
            {
                sum -= (double)(text[1] - '0');
                for (int i = 2; i < text.Length - 1; i++)
                {
                    switch (text[i])
                    {
                        case '+': sum += (double)(text[i + 1] - '0'); break;
                        case '-': sum -= (double)(text[i + 1] - '0'); break;
                        default: break;
                    }
                }
            }
            else
            {
                sum += (double)(text[0] - '0');
                for (int i = 1; i < text.Length - 1; i++)
                {
                    switch (text[i])
                    {
                        case '+': sum += (double)(text[i + 1] - '0'); break;
                        case '-': sum -= (double)(text[i + 1] - '0'); break;
                        default: break;
                    }
                }
            }

            Console.WriteLine("{0:F2}", sum);

        }
    }
}
