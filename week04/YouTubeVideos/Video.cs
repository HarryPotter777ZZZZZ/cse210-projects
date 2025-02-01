using System;
using System.Collections.Generic;
// using System.Linq;
public class Video
{
    public string Title { get; set; } //was private
    public  string Author { get; set; } //was private
    public int Length { get; set; } // was private
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment);
    {
        _comments.Add(comment);
    } 

    public void GetNumberOfComments()
    {
        return _comments.Count;
    }   

    public List<Comment> GetComments()
    {
        rettun _comments;
    }
)