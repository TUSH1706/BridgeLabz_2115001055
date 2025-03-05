using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookAggregation
{
    public class Library
    {
        public string name;
        List<Book> books;

        public Library(string name)
        {
            this.name = name;
            books = new List<Book>();
        }

        public void addBook(Book book)
        {
            books.Add(book);
        }
        public void displayBooks()
        {
            Console.WriteLine($"Library: {name} \nBooks Available:");
            foreach (var book in books)
            {
                book.display();
            }

        }
    }


    public class Book
    {
        public string title;
        public string author;
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void display()
        {
            Console.WriteLine($"Book: {title}, Author: {author}");
        }
    }
}
