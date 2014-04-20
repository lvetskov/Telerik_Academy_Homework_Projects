using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    //Write a program to check if in a given expression the brackets are put correctly.Example of correct expression: ((a+b)/5-d).Example of incorrect expression: )(a+b)).

    class ExpressionCheck
    {
        static int counter = 0; 
        static bool ExpressionCheck(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    counter++;
                }
                else if (s[i] == ')')
                {
                    counter--;
                }
                if (counter < 0)
                {
                    return false;
                }
            }
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }
            return (counter == 0);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an expression to check whether it is correct:");
            string expression = Console.ReadLine();
            Console.WriteLine("Is the expression correct: {0}", ExpressionCheck(expression));
            
        }
    }
}
