using System;
class UnicodeCode72
{   //Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
    static void Main()
    {
        int a = 0x48;
        char symbol = Convert.ToChar(a);
        Console.WriteLine(symbol);
    }
}
