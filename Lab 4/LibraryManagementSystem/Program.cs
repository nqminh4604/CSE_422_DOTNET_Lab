using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Service;

IBookRepository bookRepo = new BookRepository();
IReaderRepository readerRepo = new ReaderRepository();
ILibraryService libraryService = new LibraryService(bookRepo, readerRepo);
ReportService reportService = new ReportService(readerRepo, bookRepo);

// Add sample books
bookRepo.AddBook(new Book(1, "C# Fundamentals", "John Doe", "Programming", 3));
bookRepo.AddBook(new Book(2, "Design Patterns", "Gamma", "Software", 2));

// Add sample readers
readerRepo.AddReader(new Reader(1, "Alice"));
readerRepo.AddReader(new Reader(2, "Bob"));

// Borrow books
libraryService.LendBook(1, 1);
libraryService.LendBook(1, 2);
libraryService.LendBook(2, 1);

// Return books
libraryService.ReturnBook(1, 1);

// Generate report
reportService.GenerateReport();