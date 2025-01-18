using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class BorrowTransaction : Transaction
    {
        public BorrowTransaction(string transactionID, DateTime transactionDate, Member member, Book borrowedBook) : base(transactionID, transactionDate, member)
        {
            this.BorrowedBook = borrowedBook;
        }

        public Book BorrowedBook { get; set; }

        public override void Excute()
        {
            Console.WriteLine("Excute BorrowTransaction");
            Console.WriteLine(BorrowedBook.DisplayInfo());
        }
    }
}
