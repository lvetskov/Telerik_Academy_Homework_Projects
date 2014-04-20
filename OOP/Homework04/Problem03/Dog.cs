using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class Dog : Animals, ISound
    {
        public Dog(int age, string name, SexEnum sex)
            : base(age, name, sex)
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("bau");
        }
    }
}
