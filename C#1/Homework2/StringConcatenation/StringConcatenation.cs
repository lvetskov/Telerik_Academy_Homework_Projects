﻿using System;
class StringConcatenation
{   //Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).


    static void Main()
    {
        string one = "Hello";
        string two = "World";
        object conc = one + " " + two;
        Console.WriteLine(conc);
        string three = (string)conc;
        Console.WriteLine(three);
    }
}