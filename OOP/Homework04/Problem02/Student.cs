using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public class Student: Human
    {
        //Field
        private int grade;

        //Constructor
        public Student(string firstName, string lastName, int grade)
            :base(firstName, lastName)
        {
            this.Grade = grade;
        }

        //Property
        public int Grade
        {
            get 
            {
                return grade; 
            }
            set 
            {
                if (value > 1 && value <7)
                {
                    grade = value; 
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The grade should be between 2 and 6!");
                }
                
            }
        }
        //Methods
        public string GetFirstName()
        {
            return this.FirstName;
        }
        public string GetLastName()
        {
            return this.LastName;
        }
        public override string ToString()
        {
            return string.Format("I am {0} {1} and I am in {2} grade.", 
                GetFirstName(), GetLastName(), this.grade);
        }
    }
}
