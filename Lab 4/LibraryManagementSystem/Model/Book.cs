using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    internal class Book
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Category { get; private set; }
        public int Quantity { get; private set; }

        public Book(int id, string title, string author, string category, int quantity)
        {
            Id = id;
            Title = title;
            Author = author;
            Category = category;
            Quantity = quantity;
        }

        public void Borrow()
        {
            if (Quantity > 0)
                Quantity--;
        }

        public void Return()
        {
            Quantity++;
        }
    }
}
