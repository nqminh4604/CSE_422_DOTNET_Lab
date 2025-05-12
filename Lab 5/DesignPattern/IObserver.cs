using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal interface IObserver
    {
        void Update(string message);
    }

    internal class User : IObserver
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public void Update(string message)
        {
            Console.WriteLine($"Notification for {Name}: {message}");
        }
    }

    internal class Library
    {
        private readonly List<IObserver> _observers = new();

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        public void AddDocument(Document document)
        {
            Console.WriteLine($"{document.Title} ({document.GetDocumentType()}) added to the library.");
            NotifyObservers($"New document added: {document.Title}");
        }

        public void BorrowDocument(Document document)
        {
            NotifyObservers($"Document borrowed: {document.Title}");
        }

        public void ReturnDocument(Document document)
        {
            NotifyObservers($"Document returned: {document.Title}");
        }
    }

}
