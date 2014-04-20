using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Student: ICloneable, IComparable
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string address;
        private int ssn;
        private uint phone;
        private byte course;
        private University university;
        private Specialty specialty;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName, string address, uint phone, byte course, int ssn, 
            Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Address = address;
            this.Phone = phone;
            this.Course = course;
            this.SSN = ssn;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }



        public string  FirstName
        {
            get 
            {
                return firstName;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty.");
                }
                firstName = value; 
            }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty.");
                }
                middleName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty.");
                }
                lastName = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The address cannot be empty.");
                }
                address = value;
            }
        }

        public int SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }
        public uint Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public byte Course
        {
            get { return course; }
            set { course = value; }
        }
        public Specialty Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }
        public University University
        {
            get { return university; }
            set { university = value; }
        }
        public Faculty Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public override string ToString()
        {
            StringBuilder build = new StringBuilder();
            build.AppendLine(this.FirstName);
            build.AppendLine(this.MiddleName);
            build.AppendLine(this.LastName);
            build.AppendLine(this.Address);
            build.AppendLine(this.Phone.ToString());
            build.AppendLine(this.Course.ToString());
            build.AppendLine(this.SSN.ToString());
            build.AppendLine(this.Specialty.ToString());
            build.AppendLine(this.University.ToString());
            build.AppendLine(this.Faculty.ToString());

            return build.ToString();
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }
            if (this.SSN != student.SSN)
            {
                return false;
            }

            return true;
        }
    
        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }
        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }
        public override int GetHashCode()
        {
            return LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        public Student Clone()
        {
            Student clone = new Student
                (
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.Address,
                this.Phone,
                this.Course,
                this.SSN,
                this.Specialty,
                this.University,
                this.Faculty
                );
            return clone;
        }
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(object param)
        {
            Student student = param as Student;
            if (student==null)
            {
                return -1;
            }
            if (this.LastName != student.LastName)
            {
                return (String.Compare(this.LastName, student.LastName));
            }
            if (this.FirstName != student.FirstName)
            {
                return (String.Compare(this.FirstName, student.FirstName));
            }
            if (this.SSN != student.SSN)
            {
                return (this.SSN - student.SSN);
            }
            return 0;
        }
    }
}
