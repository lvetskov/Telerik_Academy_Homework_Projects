using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Student[] StudentArr { get; set; }
        public Student(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.LastName = secondName;
        }
    }
}