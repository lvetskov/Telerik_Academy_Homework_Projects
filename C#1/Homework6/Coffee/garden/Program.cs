using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int tomatoseed = int.Parse(Console.ReadLine());
            if (tomatoseed<0 || tomatoseed>1000)
            {
                Environment.Exit(0);
            }
            int tomatoarea = int.Parse(Console.ReadLine());
            if (tomatoarea < 0 || tomatoarea > 250)
            {
                Environment.Exit(0);
            }
            int cucumberseed = int.Parse(Console.ReadLine());
            if (cucumberseed < 0 || cucumberseed > 1000)
            {
                Environment.Exit(0);
            }
            int cucumberarea = int.Parse(Console.ReadLine());
            if (cucumberarea < 0 || cucumberarea > 250)
            {
                Environment.Exit(0);
            }
            int potatoseed = int.Parse(Console.ReadLine());
            if (potatoseed < 0 || potatoseed > 1000)
            {
                Environment.Exit(0);
            }
            int potatoarea = int.Parse(Console.ReadLine());
            if (potatoarea < 0 || potatoarea > 250)
            {
                Environment.Exit(0);
            }
            int carrotseed = int.Parse(Console.ReadLine());
            if (carrotseed < 0 || carrotseed > 1000)
            {
                Environment.Exit(0);
            }
            int carrotarea = int.Parse(Console.ReadLine());
            if (carrotarea < 0 || carrotarea > 250)
            {
                Environment.Exit(0);
            }
            int cabbageseed = int.Parse(Console.ReadLine());
            if (cabbageseed < 0 || cabbageseed > 1000)
            {
                Environment.Exit(0);
            }
            int cabbagearea = int.Parse(Console.ReadLine());
            if (cabbagearea < 0 || cabbagearea > 250)
            {
                Environment.Exit(0);
            }
            int beansseed = int.Parse(Console.ReadLine());
            if (beansseed < 0 || beansseed > 1000)
            {
                Environment.Exit(0);
            }
            double totalcost = 0.5 * tomatoseed + 0.4 * cucumberseed + 0.25 * potatoseed + 0.6 * carrotseed + 0.3 * cabbageseed + 0.4 * beansseed;
            Console.WriteLine("Total costs: {0:F2}", totalcost);
            int area = tomatoarea + cucumberarea + potatoarea + carrotarea + cabbagearea;
            if (area>250)
            {
                Console.WriteLine("Insufficient area");
            }
            else if (area<250)
            {
                Console.WriteLine("Beans area: {0}", 250 - area);
            }
            else if (area == 250)
            {
                Console.WriteLine("No area for beans");
            }
        }
    }
}
