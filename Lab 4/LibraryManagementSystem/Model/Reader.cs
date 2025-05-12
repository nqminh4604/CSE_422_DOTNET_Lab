using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    internal class Reader
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public List<int> BorrowedBooks { get; private set; }

        public Reader(int id, string name)
        {
            Id = id;
            Name = name;
            BorrowedBooks = new List<int>();
        }

        public void BorrowBook(int bookId)
        {
            if (BorrowedBooks.Count < 3)
                BorrowedBooks.Add(bookId);
        }

        public void ReturnBook(int bookId)
        {
            BorrowedBooks.Remove(bookId);
        }
    }
}
