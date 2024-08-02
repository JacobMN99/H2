namespace BibSystemTest;

//Navngivning p� din test er ikke s�rlig retvisende for hvad det er for test du vil k�re.
public class UnitTest1
{
    //Der mangler minimum en assertion for at denne test kan give mening.
    [Fact]
    public void FindBookByISBNStressTest()
    {
        for (int i = 0; i < 99999; i++)
        {
            Library.instance.AddBook(new Book($"Title{i}", $"Author{i}", $"ISBN{i}"));
        }

        Library.instance.FindBookByISBN("ISBN19999");
    }

    [Fact]
    public void PremiumUserBooks()
    {
        PremiumUser user = new("Test");
        for (int i = 0; i < 6; i++)
        {
            user.BorrowBook(new Book($"Title{i}", $"Author{i}", $"ISBN{i}"));
        }
        Assert.Equal(6, user.BorrowedBooks.Count);
    }

    [Fact]
    public void UserBooks()
    {
        User user = new("Test");
        for (int i = 0; i < 5; i++)
        {
            user.BorrowBook(new Book($"Title{i}", $"Author{i}", $"ISBN{i}"));
        }
        Assert.Equal(5, user.BorrowedBooks.Count);
    }

    [Fact]
    public void ReturnBooks()
    {
        User user = new("Test");
        for (int i = 0; i < 5; i++)
        {
            user.BorrowBook(new Book($"Title{i}", $"Author{i}", $"ISBN{i}"));
        }
        user.ReturnBook(user.BorrowedBooks[0]);
        Assert.Equal(4, user.BorrowedBooks.Count);
    }

    //Der mangler en hel del test for at d�kke alle metoderne i Library klassen.
    //S� som AddUser, DisplayAllBooks, DisplayAvailableBooks, RemoveBook

    //Der mangler en hel del test for at d�kke alle metoderne i User og Premium User klassen.
    //S� som BorrowBook, ReturnBook
}