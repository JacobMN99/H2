public class Library
{
    // Personligt ville jeg kalde instancen af Library for noget andet end instance,
    // da man hvis man kommer længere ned i koden ikke
    // ved hvad instance er uden at man skal køre musen
    // henover den for at se at det faktisk er Library der er tale som.
    // og hvorfor er den statisk?
    public static Library instance = new();

    //Hvorfor har du valgt at bruge et Dictionary her også en liste for brugere?
    private Dictionary<string, Book> books = new();
    List<User> users = new();

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