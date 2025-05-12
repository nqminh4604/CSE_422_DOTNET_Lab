using System;

public class PremiumMember : Member
{
    public DateTime MembershipExpiry { get; set; }
    public int MaxBooksAllowed { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Premium Member Information:");
        Console.WriteLine($"Membership Expiry: {MembershipExpiry:yyyy-MM-dd}");
        Console.WriteLine($"Max Books Allowed: {MaxBooksAllowed}");
    }
}
