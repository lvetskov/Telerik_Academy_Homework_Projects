//Disciplines have name, number of lectures and number of exercises. 
namespace Homework04
{
    using System.Collections.Generic;
   
    class Disciplines: ICommentable
    {
        private List<string> comments;

        public Disciplines(string name, int numberOfLectures, int numberOfExcercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExcercises;
        }


        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercises { get; set; }
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

        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }
    }
}
