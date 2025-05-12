public class BookClass
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}

public record BookRecord(string ISBN, string Title, string Author);

class Program
{
    static void Main(string[] args)
    {
        BookClass bookClass1 = new BookClass { ISBN = "123", Title = "C# Basics", Author = "John Doe" };
        BookClass bookClass2 = new BookClass { ISBN = "123", Title = "C# Basics", Author = "John Doe" };

        Console.WriteLine("BookClass comparison (==): " + (bookClass1 == bookClass2)); 

        BookRecord bookRecord1 = new BookRecord("123", "C# Basics", "John Doe");
        BookRecord bookRecord2 = new BookRecord("123", "C# Basics", "John Doe");

        Console.WriteLine("BookRecord comparison (==): " + (bookRecord1 == bookRecord2));

        BookRecord modifiedBookRecord = bookRecord1 with { Author = "Jane Smith" };
        Console.WriteLine("Modified BookRecord:");
        Console.WriteLine($"ISBN: {modifiedBookRecord.ISBN}, Title: {modifiedBookRecord.Title}, Author: {modifiedBookRecord.Author}");

        BookClass modifiedBookClass = new BookClass
        {
            ISBN = bookClass1.ISBN,
            Title = bookClass1.Title,
            Author = "Jane Smith"
        };
        Console.WriteLine("Modified BookClass:");
        Console.WriteLine($"ISBN: {modifiedBookClass.ISBN}, Title: {modifiedBookClass.Title}, Author: {modifiedBookClass.Author}");
    }
}
