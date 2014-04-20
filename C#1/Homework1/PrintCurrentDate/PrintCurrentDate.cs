using System;
//Create a console application that prints the current date and time .
class PrintCurrentDate
{
    static void Main()
    {
           Console.Write("Today is: ");
           Console.WriteLine(DateTime.Today.ToString("dd/MM/yyyy"));
           Console.Write("Time is: ");
           Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
    }
}
