using System;
//Create a console application that calculates and prints the square of the number 12345.
class SquareOfNumber
{
    static void Main()
    {
        int value = 12345;
     //   value = SquareOfNumber.value;
        double result = Math.Pow(value, 2);
        System.Console.WriteLine(result);
    }
}

