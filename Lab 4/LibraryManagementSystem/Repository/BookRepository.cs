using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Repository
{
    internal class BookRepository : IBookRepository
    {
        private readonly List<Book> books = new();

        public void AddBook(Book book) => books.Add(book);
        public List<Book> SearchBooks(string title, string category) => books.Where(b => b.Title.Contains(title) || b.Category.Contains(category)).ToList();
        public Book GetBookById(int id) => books.FirstOrDefault(b => b.Id == id);
    }

}
