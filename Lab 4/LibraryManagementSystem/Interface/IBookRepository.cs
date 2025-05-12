using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Interface
{
    internal interface IBookRepository
    {
        void AddBook(Book book);
        List<Book> SearchBooks(string title, string category);
        Book GetBookById(int id);
    }
}
