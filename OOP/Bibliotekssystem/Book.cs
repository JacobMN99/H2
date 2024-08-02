public class Book
{
    string title;
    string author;
    string isbn;
    bool available;
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string ISBN
    {
        get { return isbn; }
        set { isbn = value; }
    }

    public bool Available
    {
        get { return available; }
        set { available = value; }
    }

    public Book(string title, string author, string isbn)
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
        available = true;
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"ISBN: {isbn}");
        Console.WriteLine($"Available: {available}");
    }
}