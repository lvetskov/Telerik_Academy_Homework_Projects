using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _369
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 1 || a > 999999)
            {
                Environment.Exit(0);
            }
            int b = int.Parse(Console.ReadLine());
            if (b < 1 || b > 999999)
            {
                Environment.Exit(0);
            }
            int c = int.Parse(Console.ReadLine());
            if (c < 1 || c > 999999)
            {
                Environment.Exit(0);
            }

            //--------------------------------------
            int R = 0;
            if (b == 3)
            {
                R = a + c;
            }
            else if (b == 6)
            {
                R = a * c;
            }
            else if (b == 9)
            {
                R = a % c;
            }
            else
            {
                Environment.Exit(0);
            }
            if (R % 3 == 0)
            {
                Console.WriteLine(R / 3);
            }
            else
            {
                Console.WriteLine(R % 3);
            }
            Console.WriteLine(R);



        }
    }
}
