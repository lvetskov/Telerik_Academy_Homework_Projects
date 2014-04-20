using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.User_input
{
    class userInput
    {
        static void Main(string[] args)
        {
            Console.Write("Enter input: ");
            string input = Console.ReadLine();
            int i = 0;
            double d = 0;
            bool check = true;

            if (check == Int32.TryParse(input, out i))
            {
                input++;
                Console.WriteLine("Integer {0}", input);
            }
            else if (check == double.TryParse(input, out d))
            {
                input++;
                Console.WriteLine("Double {0}", input);
            }
            else
            {
                Console.WriteLine("String" + input + "*");
            }
        }
    }
}
