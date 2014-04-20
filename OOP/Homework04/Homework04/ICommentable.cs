namespace Homework04
{
    public interface ICommentable
    {
        string[] Comments { get; }
        void AddComment(string comment);
    }
}
