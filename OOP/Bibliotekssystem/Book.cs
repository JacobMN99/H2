public class Book
{
    //Der er ingen grund til at lave dine properties dobbelt, du kan lavet dem som auto properties
    //og sætte deres accessors til private hvis det er nødvendigt.
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

    //Available skal kun kunne sætte fra Borrow og Return Book metoder, lige pt er den public i både set og get funktionen.
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