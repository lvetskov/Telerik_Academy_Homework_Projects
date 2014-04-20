using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public abstract class Cat : Animals
    {
        public Cat(int age, string name, SexEnum sex)
            : base(age, name, sex)
        {

        }
    }
}
