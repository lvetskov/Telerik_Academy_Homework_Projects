using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Student
    {
        public Student(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
