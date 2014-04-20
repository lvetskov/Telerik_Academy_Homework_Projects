using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public class TomCat : Cat, ISound
    {
        public TomCat(int age, string name, SexEnum sex)
            : base(age, name, sex)
        {
            if (sex != SexEnum.Male)
            {
                throw new ArgumentException("TomCats must be male");
            }
        }

        public void MakeSound()
        {
            Console.WriteLine("murr");
        }
    }
}
