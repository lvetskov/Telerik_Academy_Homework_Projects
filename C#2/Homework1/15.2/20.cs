using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        //Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            bool simpleDevision2 = false;
            bool simpleDevision3 = false;
            bool simpleDevision5 = false;
            bool simpleDevision7 = false;
            for (int i = 0; i < 9999999; i++)               //!!!!!!!!!!!!!!!!!!! Way more faster!!! Just the print is slow
            {
                intList.Add(i + 1);
            }
            for (int i = 0; i < intList.Count; i++)            //
            {                                                  //
                if (intList[i] % 2 == 0)                       //
                {                                              //removes all numbers that are dividable by 2
                    intList[i] = 0;                            //
                    simpleDevision2 = true;                    //
                }                                              //
            }                                                  
            for (int i = 0; i < intList.Count; i++)              //
            {                                                    //
                if (intList[i] % 3 == 0)                         //
                {                                                //removes all numbers that are dividable by 3
                    intList[i] = 0;                              //
                    simpleDevision3 = true;                      //
                }                                                //
            }
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] % 5 == 0)
                {
                    intList[i] = 0;
                    simpleDevision5 = true;
                }
            }
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] % 7 == 0)
                {
                    intList[i] = 0;
                    simpleDevision7 = true;
                }
            }
            Console.WriteLine(1);
            if (simpleDevision2)
            {
                Console.WriteLine(2);
            }
            if (simpleDevision3)
            {
                Console.WriteLine(3);
            }
            if (simpleDevision5)
            {
                Console.WriteLine(5);
            }
            if (simpleDevision7)
            {
                Console.WriteLine(7);
            }

            for (int i = 1; i < intList.Count; i++)
            {
                if (intList[i] != 0)
                {
                    Console.WriteLine(intList[i]);
                }
                
            }
        }
    }
}
