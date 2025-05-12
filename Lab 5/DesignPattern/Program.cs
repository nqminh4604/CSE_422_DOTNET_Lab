using DesignPattern;

public class Program
{
    public static void Main()
    {
        // Singleton: Database Connection
        var db = DatabaseConnection.GetInstance();
        Console.WriteLine("Database connected: " + db);

        // Observer: Users subscribing for notifications
        var user1 = new User { Id = 1, Name = "Alice" };
        var user2 = new User { Id = 2, Name = "Bob" };

        var library = new Library();
        library.RegisterObserver(user1);
        library.RegisterObserver(user2);

        // Factory: Creating a book and adding it to the library
        var book = DocumentFactory.CreateDocument("Book");
        book.Title = "C# Programming";
        library.AddDocument(book);

        // Strategy: Calculating loan fee
        var bookLoan = new Loan(new BookLoanFee());
        Console.WriteLine($"Loan Fee for 10 days: ${bookLoan.GetLoanFee(10)}");

        // Borrow and return a document
        library.BorrowDocument(book);
        library.ReturnDocument(book);
    }
}
