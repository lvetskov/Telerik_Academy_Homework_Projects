using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoGirlsOnePath
{
    class TwoGirlsOnePath
    {
        static long mollyFlowers = 0;
        static long mollyCurrentCollect = 0;
        static bool mollyInMove = true;
        static long mollyPosition = 0;

        static long dollyFlowers = 0;
        static long dollyCurrentCollect = 0;
        static bool dollyInMove = true;
        static long dollyPosition = 0;

        static bool Molly(params long[] cellsInLong)
        {
            if (mollyCurrentCollect + mollyPosition > cellsInLong.Length - 1)
            {
                mollyPosition = (mollyCurrentCollect + mollyPosition) % (cellsInLong.Length - 1);
            }
            else
            {
                mollyPosition = mollyCurrentCollect + mollyPosition;
            }

            mollyCurrentCollect = cellsInLong[mollyPosition];
            mollyFlowers += mollyCurrentCollect;
            cellsInLong[mollyPosition] = 0;
            if (mollyCurrentCollect == 0)
            {
                return false;
            }
            return true;

        }

        static bool Dolly(params long[] cellsInLong)
        {

            if (dollyPosition - dollyCurrentCollect < 1)
            {
                dollyPosition = dollyPosition - (dollyCurrentCollect % (cellsInLong.Length - 1));
            }
            else
            {
                dollyPosition = dollyPosition - dollyCurrentCollect;
            }
            if (dollyPosition <= 0)
            {
                dollyPosition = cellsInLong.Length - 1 + dollyPosition;
            }
            dollyCurrentCollect = cellsInLong[dollyPosition];
            dollyFlowers += dollyCurrentCollect;
            cellsInLong[dollyPosition] = 0;
            if (mollyPosition == dollyPosition)
            {
                if (mollyCurrentCollect % 2 == 0)
                {
                    mollyFlowers -= mollyCurrentCollect / 2;
                    dollyFlowers += mollyCurrentCollect / 2;
                    dollyCurrentCollect = mollyCurrentCollect;
                }
                else
                {
                    mollyFlowers -= (mollyCurrentCollect - 1) / 2;
                    dollyFlowers += (mollyCurrentCollect - 1) / 2;
                    dollyCurrentCollect = mollyCurrentCollect;
                    cellsInLong[dollyPosition] = mollyCurrentCollect % 2; //=1
                }
            }
            if (dollyCurrentCollect == 0)
            {
                return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] cellsInString = input.Split(' ');
            long[] cellsInLong = new long[cellsInString.Length + 1];
            for (int i = 0; i < cellsInString.Length; i++)
            {
                cellsInLong[i + 1] = long.Parse(cellsInString[i]);
            }

            mollyFlowers += cellsInLong[1];
            mollyCurrentCollect = cellsInLong[1];
            cellsInLong[1] = 0;
            mollyPosition = 1;

            dollyFlowers += cellsInLong[cellsInLong.Length - 1];
            dollyCurrentCollect = cellsInLong[cellsInLong.Length - 1];
            cellsInLong[cellsInLong.Length - 1] = 0;
            dollyPosition = cellsInLong.Length - 1;

            while (mollyInMove && dollyInMove)
            {
                mollyInMove = Molly(cellsInLong);
                dollyInMove = Dolly(cellsInLong);
                
            }
            if (mollyInMove == false)
            {
                Console.WriteLine("Dolly");
            }
            else if (dollyInMove == false)
            {
                Console.WriteLine("Molly");
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
        }
    }
}
