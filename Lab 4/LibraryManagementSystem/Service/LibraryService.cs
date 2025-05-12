using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Interface;

namespace LibraryManagementSystem.Service
{
    internal class LibraryService : ILibraryService
    {
        private IBookRepository bookRepository;
        private IReaderRepository readerRepository;

        public LibraryService(IBookRepository bookRepo, IReaderRepository readerRepo)
        {
            bookRepository = bookRepo;
            readerRepository = readerRepo;
        }

        public void LendBook(int readerId, int bookId)
        {
            var reader = readerRepository.GetReaderById(readerId);
            var book = bookRepository.GetBookById(bookId);

            if (reader != null && book != null && book.Quantity > 0 && reader.BorrowedBooks.Count < 3)
            {
                book.Borrow();
                reader.BorrowBook(bookId);
                Console.WriteLine($"Book '{book.Title}' borrowed by {reader.Name}.");
            }
            else
            {
                Console.WriteLine("Cannot lend book.");
            }
        }

        public void ReturnBook(int readerId, int bookId)
        {
            var reader = readerRepository.GetReaderById(readerId);
            var book = bookRepository.GetBookById(bookId);

            if (reader != null && book != null && reader.BorrowedBooks.Contains(bookId))
            {
                book.Return();
                reader.ReturnBook(bookId);
                Console.WriteLine($"Book '{book.Title}' returned by {reader.Name}.");
            }
            else
            {
                Console.WriteLine("Invalid return.");
            }
        }
    }
}
