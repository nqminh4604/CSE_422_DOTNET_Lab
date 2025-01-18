using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class ReturnTransaction : Transaction
    {
        public ReturnTransaction(string transactionID, DateTime transactionDate, Member member, Book returnBook) : base(transactionID, transactionDate, member)
        {
            this.ReturnBook = returnBook;
        }

        public Book ReturnBook { get; set; }

        public override void Excute()
        {
            Console.WriteLine("Excute ReturnTransaction");
            Console.WriteLine(ReturnBook.DisplayInfo());
        }
    }
}
