using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NotificationService
{
    public virtual void SendNotification(string message)
    {
        Console.WriteLine(message);
    }
    public void SendNotification(string message, string recipient)
    {
        Console.WriteLine("Recipient: ", recipient);
        SendNotification(message);
    }
    public void SendNotification(string message, List<string> recipients)
    {
        foreach (var recipient in recipients)
        {
            SendNotification(message, recipient);
        }
    }

    public void SendEmailNotification(Book book, Member member)
    {
        Console.WriteLine($"Email: '{book.Title}' has been borrowed by {member.Name}.");
    }

    public void LogBorrowingAction(Book book, Member member)
    {
        Console.WriteLine($"Log: Member {member.Name} borrowed '{book.Title}' on {DateTime.Now:yyyy-MM-dd HH:mm:ss}.");
    }
}
