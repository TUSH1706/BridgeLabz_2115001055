using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_2_2025
{
    public class Book
    {
        public string ISBN { get; set; }

        protected string Title { get; set; }

        private string Author;

        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        public void SetAuthor(string author)
        {
            Author = author;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}, Title: {Title}, Author: {Author}");
        }

    }

    public class EBook : Book
    {
        private double FileSize; // File size in MB

        public EBook(string isbn, string title, string author, double fileSize)
            : base(isbn, title, author) // Call base class constructor
        {
            FileSize = fileSize;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}, Title: {Title}, File Size: {FileSize}MB, Author: {GetAuthor()}");
        }
    }
}
