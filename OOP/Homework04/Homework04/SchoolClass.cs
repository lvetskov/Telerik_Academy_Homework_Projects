namespace Homework04
{
    using System;
    using System.Collections.Generic;

    class SchoolClass : ICommentable
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private string id;
        private List<string> comments;

        public SchoolClass(Student[] students, Teacher[] teachers, string id)
        {
            this.students = new List<Student>(students);
            this.teachers = new List<Teacher>(teachers);
            this.id = id;
            this.comments = new List<string>();
        }

        public Student[] Students
        {
            get
            {
                return this.students.ToArray();
            }

        }
        public Teacher[] Teachers
        {
            get
            {
                return this.teachers.ToArray();
            }
        }
        public string Id { get; set; }
        public string[] Comments
        {
            get
            {
                return this.comments.ToArray();
            }
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }
        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }
        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }
    }
}
