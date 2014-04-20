using System;

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
                int newI = int.Parse(input);
                newI++;
                Console.WriteLine("Integer {0}", newI);
            }
            else if (check == double.TryParse(input, out d))
            {
                double newD = double.Parse(input);
                newD++;
                Console.WriteLine("Double {0}", newD);
            }
            else
            {
                Console.WriteLine("String " + input + "*");
            }      
        }       
    }
}
