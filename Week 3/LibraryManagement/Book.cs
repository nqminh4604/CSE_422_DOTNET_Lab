using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Book
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
                    throw new ArgumentException("Year cannot be negative.");
                _year = value;
            }
        }


        public int CopiesAvailable
        {
            get { return _copiesAvailable; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Copies available cannot be negative.");
                _copiesAvailable = value;
            }
        }

        public Book(string isbn, string title, string author, int year, int copiesAvailable)
        {
            _isbn = isbn;
            _title = title;
            _author = author;
            _year = year;
            _copiesAvailable = copiesAvailable;
        }

        public string DisplayInfo()
        {
            string info =
                "ISBN: " + ISBN + "\n"
                + "Title: " + Title + "\n"
                + "AUthor: " + Author + "\n"
                + "Copies Available: " + CopiesAvailable + "\n"
                + "Year: " + Year + "\n";
            return info;
        }
    }
}
