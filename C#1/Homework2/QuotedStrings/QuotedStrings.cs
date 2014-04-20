using System;
class QuotedStrings
{   //Declare two string variables and assign them with following value:	Do the above in two different ways: with and without using quoted strings.


    static void Main()
    {
        string one = "The \"use\" of quotations causes difficulties ";
        Console.WriteLine(one);
        string two = @"The ""use"" of quotations causes difficulties ";
         Console.WriteLine(two);
    }
}