using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

public class Library
{
    public string LibraryName { get; set; }
    public List<Book> Books { get; set; }
    public List<Member> Members { get; set; }

    public event Action<Book, Member> OnBookBorrowed;
    public void BorrowBook(Book book, Member member)
    {
        if (book.CopiesAvailable > 0)
        {
            book.CopiesAvailable--;
            Console.WriteLine($"{member.Name} borrowed '{book.Title}'. Remaining copies: {book.CopiesAvailable}");

            OnBookBorrowed?.Invoke(book, member);
        }
        else
        {
            Console.WriteLine($"'{book.Title}' is out of stock. Borrowing failed.");
        }
    }
    public Library(string libraryName, List<Book> books, List<Member> members)
    {
        LibraryName = libraryName;
        Books = books;
        Members = members;
    }

    public Library(Library library)
    {
        LibraryName = library.LibraryName;
        Books = library.Books;
        Members = library.Members;
    }

    public Library()
    {
    }

    public void DisplayLibraryInfo()
    {
        Console.WriteLine("Number of books: ", Books.Count);
        Console.WriteLine("Number of members: ", Members.Count);
    }
}
