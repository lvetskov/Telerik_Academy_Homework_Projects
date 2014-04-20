using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    //Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so. Write a program to test this functionality.

    class Person
    {
        private string name;
        private int? age;
        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            get 
            {
                return name; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty.");
                }
                name = value; 
            }
        }
        public int? Age
        {
            get 
            {
                return age; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative");
                }
                age = value; 
            }
        }
        public override string ToString()
        {
            string toString = "Name: " + this.Name + " Age: " + (this.Age == null ? "Age is not defined" : this.Age.ToString());
            return toString;
        }
    }
}
