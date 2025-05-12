using System;

public class Member
{
    private string _memberId;
    private string _name;
    private string _email;
    public string MemberID { 
        get { return this._memberId; }
        set { this._memberId = MemberID; } 
    }
    
    public string Name
    {
        get { return this._name; }
        set { this._name = Name; } 
    }

    public string Email
    {
        get { return this._email; }
        set { this._email = value; }
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Member Information:");
        Console.WriteLine($"Member ID: {MemberID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
    }
}
