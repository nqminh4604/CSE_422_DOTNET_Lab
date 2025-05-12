using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal abstract class Document
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public abstract string GetDocumentType();
    }

    internal class Book : Document
    {
        public override string GetDocumentType() => "Book";
    }

    internal class Magazine : Document
    {
        public override string GetDocumentType() => "Magazine";
    }

    internal class Newspaper : Document
    {
        public override string GetDocumentType() => "Newspaper";
    }

    internal class DocumentFactory
    {
        internal static Document CreateDocument(string type)
        {
            return type switch
            {
                "Book" => new Book(),
                "Magazine" => new Magazine(),
                "Newspaper" => new Newspaper(),
                _ => throw new ArgumentException("Invalid document type")
            };
        }
    }
}
