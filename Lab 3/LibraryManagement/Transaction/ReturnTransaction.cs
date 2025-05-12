using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReturnTransaction : Transaction
{
    public ReturnTransaction(string transactionID, DateTime transactionDate, Member member, Book returnBook) : base(transactionID, transactionDate, member)
    {
        ReturnBook = returnBook;
    }

    public Book ReturnBook { get; set; }

    public override void Excute()
    {
        Console.WriteLine("Excute ReturnTransaction");
        ReturnBook.DisplayInfo();
    }
}
