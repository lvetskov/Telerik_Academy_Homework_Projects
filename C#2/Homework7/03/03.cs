using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    //Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
    //Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.

    class ReadFileExceptions
    {
        static void Main()
        {
            Console.Write("Enter file name:");
            try
            {
                Console.WriteLine(System.IO.File.ReadAllText(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught!\n{0}:{1}", e.GetType().Name, e.Message);
            }
        }
    }
}
