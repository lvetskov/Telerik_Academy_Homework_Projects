using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bat_goiko
{
    class goiko
    {
        static void Main(string[] args)
        {
            int H = int.Parse(Console.ReadLine());
            if (H>39 || H<2)
            {
                Environment.Exit(0);
            }
            int rowDash = 2;
            int rowPlus = 2;
            int innerSymbols = 2;
      //      int rowDot = 3;
            Console.Write(new string('.', H - 1));
            Console.Write("/\\");
            Console.WriteLine(new string('.', H - 1));
            for (int i = 2; i <= H; i++)
            {
                Console.Write(new string('.', H - i));
                Console.Write("/");
                if (i==rowDash)
                {
                    Console.Write(new string('-', innerSymbols));
                    Console.Write("\\");
                    rowDash += rowPlus;
                    rowPlus++;
                }
                else
                {
                    Console.Write(new string('.', innerSymbols));
                    Console.Write("\\");
                }
                innerSymbols += 2;
                Console.WriteLine(new string('.', H - i));

            }

        }
    }
}
