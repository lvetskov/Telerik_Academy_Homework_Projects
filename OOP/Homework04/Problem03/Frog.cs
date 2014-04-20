using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class Frog : Animals, ISound
    {
        public Frog(int age, string name, SexEnum sex)
            : base(age, name, sex)
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("gaga");
        }
    }
}
