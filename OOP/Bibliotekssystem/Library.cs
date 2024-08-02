public class Library
{
    public static Library instance = new();
    private Dictionary<string, Book> books = new();
    List<User> users = new();
    public List<Book> Books { get; set; }

    public List<User> Users { get; set; }

    public void AddBook(Book book)
    {
        books.Add(book.ISBN, book);
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void DisplayAllBooks()
    {
        foreach (var book in books)
        {
            book.Value.DisplayInfo();
        }
    }

    public void DisplayAvailableBooks()
    {
        foreach (var book in books)
        {
            if (book.Value.Available)
            {
                book.Value.DisplayInfo();
            }
        }
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book.ISBN);
    }

    public void FindBookByISBN(string isbn)
    {
        if (books.TryGetValue(isbn, out Book book))
        {
            book.DisplayInfo();
        }
        else 
        {
            Console.WriteLine("Book not found.");
        }
    }
}