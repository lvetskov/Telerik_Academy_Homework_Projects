using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 aNumber = new BitArray64(5);
            foreach (var item in aNumber.Bits)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
