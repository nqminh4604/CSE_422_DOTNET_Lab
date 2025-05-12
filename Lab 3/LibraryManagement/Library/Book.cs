using System;

public class Book
{
    private string _isbn;
    private string _title;
    private string _author;
    private int _year;
    private int _copiesAvailable;

    public string ISBN
    {
        get { return _isbn; }
        set { _isbn = value; }
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public int Year
    {
        get { return _year; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Year cannot be less than 0.");
            }
            _year = value;
        }
    }

    public int CopiesAvailable
    {
        get { return _copiesAvailable; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("CopiesAvailable cannot be less than 0.");
            }
            _copiesAvailable = value;
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Book Information:");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Copies Available: {CopiesAvailable}");
    }
}
