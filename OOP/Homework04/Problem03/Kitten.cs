using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class Kitten : Cat, ISound
    {
        public Kitten(int age, string name, SexEnum sex)
            : base(age, name, sex)
        {
            if (sex != SexEnum.Female)
            {
                throw new ArgumentException("Kittens must be female");
            }
        }

        public void MakeSound()
        {
            Console.WriteLine("miau");
        }
    }
}
