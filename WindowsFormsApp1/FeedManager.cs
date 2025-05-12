using System;
using WindowsFormsApp1;

public class FeedManager
{
    private Post head;
    private Post tail;
    private Post current;
    private int counter = 1;
    public static  FeedManager feedmanager = new FeedManager();

    public void AddPost(string title, string content,string name)
    {
        Post newPost = new Post
        {
            Title = title,
            Content = content,
            Name = name,
            Timestamp = DateTime.Now
        };

        if (head == null)
        {
            head = tail = current = newPost;
        }
        else
        {
            tail.Next = newPost;
            newPost.Prev = tail;
            tail = newPost;
        }
    }

    public Post GetCurrent() => current;

    public void MoveNext() { if (current?.Next != null) current = current.Next; }

    public void MovePrevious() { if (current?.Prev != null) current = current.Prev; }

    public void DeleteCurrent()
    {
        if (current == null) return;

        if (current.Prev != null) current.Prev.Next = current.Next;
        else head = current.Next;

        if (current.Next != null) current.Next.Prev = current.Prev;
        else tail = current.Prev;

        current = current.Next ?? current.Prev;
    }
}
