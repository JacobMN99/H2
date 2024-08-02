public class User
{
    readonly int Id;
    string name;
    List<Book> borrowedBooks = new();
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

    public virtual bool BorrowBook(Book book)
    {
        if (BorrowedBooks.Count < 5)
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

    public void ReturnBook(Book book)
    {
        BorrowedBooks.Remove(book);
        book.Available = true;
    }

    void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Borrowed books:");
        foreach (var book in borrowedBooks)
        {
            book.DisplayInfo();
        }
    }

    public User(string name)
    {
        this.name = name;
    }

}