using System;

class Video
{
    public string _author;
    public string _title;
    public int _length;

    public List<Comment> _comList = new List<Comment>(); 

    public void Display()
    {
        Console.WriteLine($"Name: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of comments: {_comList.Count}");

        foreach (Comment comment in _comList)
        {
            comment.PrintComment();
        }
    }

}