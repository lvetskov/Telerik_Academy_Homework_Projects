using System;
using System.Collections.Generic;
using System.Threading;

public class Example
{
    static void Main()
    {
        string test = "alabala   portokala ";
        string[] result = test.Split(' ');
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }


    }





}
