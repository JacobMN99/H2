using System.Xml;

public class PremiumUser : User
{
    readonly int id;
    string name;
    List<Book> borrowedBooks = new List<Book>();
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    public List<Book> BorrowedBooks
    {
        get { return borrowedBooks; }
        set { borrowedBooks = value; }
    }
    public PremiumUser(string name) : base(name)
    {
        this.name = name;
    }

    public override bool BorrowBook(Book book)
    {
        if (BorrowedBooks.Count < 6)
        {
            BorrowedBooks.Add(book);
            book.Available = false;
            return true;
        }
        else
        {
            Console.WriteLine("You have reached the maximum number of borrowed books.");
            return false;
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Borrowed books:");
        foreach (var book in borrowedBooks)
        {
            book.DisplayInfo();
        }
    }

    public void ReturnBook(Book book)
    {
        BorrowedBooks.Remove(book);
        book.Available = true;
    }
}