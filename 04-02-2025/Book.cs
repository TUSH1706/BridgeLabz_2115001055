using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public static string LibraryName = "GLAU Central Library";
        public readonly string ISBN;

        private string title;
        private string author;


        public Book(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.ISBN = isbn;
        }

        public static void DisplayLibraryName()
        {
            Console.WriteLine($"Library Name: {LibraryName}");
        }

        public string GetBookDetails()
        {
            return $"Title: {title}\nAuthor: {author}\nISBN: {ISBN}";
        }

        public static void DisplayBookDetails(object obj)
        {
            if (obj is Book book)
            {
                Console.WriteLine(book.GetBookDetails());
            }
            else
            {
                Console.WriteLine("The object is not a Book.");
            }
        }
    }
}
