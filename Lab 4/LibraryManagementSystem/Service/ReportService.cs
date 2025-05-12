using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Interface;

namespace LibraryManagementSystem.Service
{
    internal class ReportService
    {

        private IReaderRepository readerRepository;
        private IBookRepository bookRepository;

        public ReportService(IReaderRepository readerRepo, IBookRepository bookRepo)
        {
            readerRepository = readerRepo;
            bookRepository = bookRepo;
        }

        public void GenerateReport()
        {
            Console.WriteLine("\n===== Borrowed Books Report =====");
            foreach (var reader in readerRepository.GetReaders())
            {
                Console.WriteLine($"{reader.Name} has borrowed:");
                foreach (var bookId in reader.BorrowedBooks)
                {
                    var book = bookRepository.GetBookById(bookId);
                    Console.WriteLine($"- {book.Title}");
                }
                Console.WriteLine();
            }
        }
    }
}
