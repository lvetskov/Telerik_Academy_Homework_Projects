//the horror - 70 points
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livingCode
{
    class livingCode
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            number = number.TrimStart(new char[] { '-' });
            int counter = 0;
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (i % 2 == 0)
                {
                    counter++;
                    sum += Convert.ToInt32(number[i] - '0');
                }
            }
            Console.Write(counter);
            Console.WriteLine(" {0}", sum);
        }
    }
}
