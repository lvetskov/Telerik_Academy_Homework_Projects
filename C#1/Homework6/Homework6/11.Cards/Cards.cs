using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            string[] suits = new string[4] { "Spades", "Hearts", "Diamonds", "Clubs" };
            foreach (string suit in suits)
            {
                for (int card = 2; card <= 14; card++)
                {
                    switch (card)
                    {
                        case 2: Console.WriteLine("{1} of {0}", suit, card); break;
                        case 3: Console.WriteLine("{1} of {0}", suit, card); break;
                        case 4: Console.WriteLine("{1} of {0}", suit, card); break;
                        case 5: Console.WriteLine("{1} of {0}", suit, card); break;
                        case 6: Console.WriteLine("{1} of {0}", suit, card); break;
                        case 7: Console.WriteLine("{1} of {0}", suit, card); break;
                        case 8: Console.WriteLine("{1} of {0}", suit, card); break;
                        case 9: Console.WriteLine("{1} of {0}", suit, card); break;
                        case 10: Console.WriteLine("{1} of {0}", suit, card); break;
                        case 11: Console.WriteLine("Jack of {0}", suit); break;
                        case 12: Console.WriteLine("Queen of {0}", suit); break;
                        case 13: Console.WriteLine("King of {0}", suit); break;
                        case 14: Console.WriteLine("Ace of {0}", suit); break;
                    }
                }
            }
        }
    }
}
