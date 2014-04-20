namespace Homework04
{
    using System.Collections.Generic;

    class Student : People, ICommentable
    {
        private List<string> comments;

        public Student(string name, int id)
            :base(name)
        {
            this.iD = id;
        }

        public int iD { get; set; }
        public string[] Comments
        {
            get
            {
                return this.comments.ToArray();
            }
        }

        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }
    }
}
