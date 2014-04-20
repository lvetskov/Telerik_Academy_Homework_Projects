using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    public abstract class Human
    {
        //Fields
        private readonly string firstName;
        private readonly string lastName;


        //Constructor
        protected Human(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentNullException("A first name should be entered");
            }
            else
            {
                this.firstName = firstName;
            }
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException("A first name should be entered");
            }
            else
            {
                this.lastName = lastName;
            }

        }

        //Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
        }


    }
}
