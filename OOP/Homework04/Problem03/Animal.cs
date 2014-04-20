using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    public abstract class Animals
    {
        private int age;
        private string name;
        private SexEnum sex;

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentException("Invalid age");
                }
                this.age = value;
            }
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length <= 2 || value.Length > 50)
                {
                    throw new ArgumentException("Invalid name");
                }
                this.name = value;
            }
        }
        public SexEnum Sex
        {
            get { return this.sex; }
            private set { this.sex = value; }
        }

        protected Animals(int age, string name, SexEnum sex)
        {
            this.Age = age;
            this.Name = name;
            this.sex = sex;
        }
    }
}
