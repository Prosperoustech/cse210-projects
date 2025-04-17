using System.Collections.Generic;

public class Video
{
    private string             _title;
    private string             _author;
    private int                _lengthInSeconds;
    private List<Comment>      _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title            = title;
        _author           = author;
        _lengthInSeconds  = lengthInSeconds;
        _comments         = new List<Comment>();
    }

    public string Title            => _title;
    public string Author           => _author;
    public int    LengthInSeconds  => _lengthInSeconds;

    public void AddComment(Comment comment) =>
        _comments.Add(comment);

    public int GetNumberOfComments() =>
        _comments.Count;

    public IReadOnlyList<Comment> Comments =>
        _comments.AsReadOnly();
}
