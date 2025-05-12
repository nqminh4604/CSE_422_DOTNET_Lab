using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LibraryCard
{
    private string _cardNumber;
    private DateTime _issueDate;

    public string CardNumber
    {
        get { return _cardNumber; }
    }

    public Member Owner { get; set; }

    public LibraryCard(string cardNumber, DateTime issueDate, Member owner)
    {
        _cardNumber = cardNumber;
        _issueDate = DateTime.Now;
        Owner = owner;
    }

    public DateTime IssueDate
    {
        get { return _issueDate; }
        private set { _issueDate = value; }
    }


    public void RenewCard(string CardNumber, Member Owner)
    {
        _issueDate = DateTime.Now;
        Console.WriteLine($"The library card ({CardNumber}) for {Owner.Name} has been renewed.");
        Console.WriteLine($"New Issue Date: {_issueDate:yyyy-MM-dd}");
    }
}
