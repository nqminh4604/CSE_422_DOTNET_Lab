using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interface
{
    internal interface ILibraryService
    {
        void LendBook(int readerId, int bookId);
        void ReturnBook(int readerId, int bookId);
    }
}
