namespace Homework04
{
    using System;
    using System.Collections.Generic;

    class Teacher : People, ICommentable
    {
        private List<Disciplines> disciplines;
        private List<string> comments;

        public Teacher(string name, Disciplines[] disciplines) : base(name)
        {
            this.disciplines = new List<Disciplines>(disciplines);
        }

        public Disciplines[] Disciplines
        {
            get
            {
                return this.disciplines.ToArray();
            }
            private set
            {
            }
        }
        public string[] Comments
        {
            get
            {
                return this.comments.ToArray();
            }
            private set
            {
            }
        }

        public void AddDiscipline(Disciplines discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Disciplines discipline)
        {
            this.disciplines.Remove(discipline);
        }
        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }
    }
}
