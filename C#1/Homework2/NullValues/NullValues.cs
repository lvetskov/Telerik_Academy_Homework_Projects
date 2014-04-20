using System;
class NullValues
{   //Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.


    static void Main()
    {
        int? a = null;
        Console.WriteLine(a);
        double? b = null;
        Console.WriteLine(b);
        a = 1;
        Console.WriteLine(a);


    }
}