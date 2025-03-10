using System;

class BookNode
{
    public string BookTitle;
    public string Author;
    public string Genre;
    public int BookID;
    public bool Availability;
    public BookNode Prev;
    public BookNode Next;

    public BookNode(string bookTitle, string author, string genre, int bookID, bool availability)
    {
        BookTitle = bookTitle;
        Author = author;
        Genre = genre;
        BookID = bookID;
        Availability = availability;
        Prev = Next = null;
    }
}

class LibraryDoublyLinkedList
{
    private BookNode head;
    private BookNode tail;

    public void AddBook(string bookTitle, string author, string genre, int bookID, bool availability, int? position = null)
    {
        BookNode newNode = new BookNode(bookTitle, author, genre, bookID, availability);
        if (head == null)
        {
            head = tail = newNode;
        }
        else if (position == null || position == 0)
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
        else
        {
            BookNode temp = head;
            int count = 0;
            while (temp.Next != null && count < position - 1)
            {
                temp = temp.Next;
                count++;
            }
            newNode.Next = temp.Next;
            if (temp.Next != null)
                temp.Next.Prev = newNode;
            temp.Next = newNode;
            newNode.Prev = temp;
            if (newNode.Next == null)
                tail = newNode;
        }
    }

    public void RemoveBook(int bookID)
    {
        BookNode temp = head;
        while (temp != null && temp.BookID != bookID)
            temp = temp.Next;
        if (temp == null)
        {
            Console.WriteLine("Book not found!");
            return;
        }
        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;
        else
            head = temp.Next;
        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;
        else
            tail = temp.Prev;
        Console.WriteLine("Book removed successfully.");
    }

    public void SearchBook(string bookTitle = null, string author = null)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if ((bookTitle != null && temp.BookTitle == bookTitle) || (author != null && temp.Author == author))
                Console.WriteLine("Book ID: " +temp.BookID, "Title: " +temp.BookTitle, "Author:"  +temp.Author, "Genre: " +temp.Genre, "Available: " +temp.Availability);
            temp = temp.Next;
        }
    }

    public void UpdateAvailability(int bookID, bool availability)
    {
        BookNode temp = head;
        while (temp != null && temp.BookID != bookID)
            temp = temp.Next;
        if (temp != null)
        {
            temp.Availability = availability;
            Console.WriteLine("Availability updated successfully.");
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }

    public void DisplayBooks(bool reverse = false)
    {
        BookNode temp = reverse ? tail : head;
        while (temp != null)
        {
            Console.WriteLine("Book ID:" +temp.BookID, "Title: " +temp.BookTitle," Author: " +temp.Author, "Genre: " +temp.Genre,"Available: " +temp.Availability);
            temp = reverse ? temp.Prev : temp.Next;
        }
    }

    public int CountBooks()
    {
        int count = 0;
        BookNode temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        return count;
    }
}

class Program
{
    static void Main()
    {
        LibraryDoublyLinkedList library = new LibraryDoublyLinkedList();
        library.AddBook("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", 101, true);
        library.AddBook("1984", "George Orwell", "Dystopian", 102, false);
        library.AddBook("Moby-Dick", "Herman Melville", "Adventure", 103, true, position: 1);
        library.DisplayBooks();
        library.UpdateAvailability(102, true);
        library.DisplayBooks(reverse: true);
        Console.WriteLine("Total Books:" +library.CountBooks());
        library.RemoveBook(101);
        library.DisplayBooks();
    }
}