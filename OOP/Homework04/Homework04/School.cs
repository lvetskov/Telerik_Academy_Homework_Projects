namespace Homework04
{
    using System;
    using System.Collections.Generic;

    class School
    {
        private List<SchoolClass> classes;

        public School(SchoolClass[] classes)
        {
            this.classes = new List<SchoolClass>(classes);
        }

        public SchoolClass[] Classes
        {
            get
            {
                return this.classes.ToArray();
            }
        }

        public void AddClass(SchoolClass @class)
        {
            this.classes.Add(@class);
        }
        public void RemoveClass(SchoolClass @class)
        {
            this.classes.Remove(@class);
        }
    }
}
