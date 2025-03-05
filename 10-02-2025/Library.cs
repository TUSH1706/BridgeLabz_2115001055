using System;

// Abstract class representing a library item
abstract class LibraryItem
{
    public int ItemId { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }

    public LibraryItem(int itemId, string title, string author)
    {
        ItemId = itemId;
        Title = title;
        Author = author;
    }

    public abstract int GetLoanDuration();

    public void GetItemDetails()
    {
        Console.WriteLine($"Item ID: {ItemId}, Title: {Title}, Author: {Author}");
    }
}

// Interface for reservable items
interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

// Book class inheriting from LibraryItem
class Book : LibraryItem, IReservable
{
    public Book(int itemId, string title, string author) : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 14; // 2 weeks loan period
    }

    public void ReserveItem()
    {
        Console.WriteLine($"Book '{Title}' has been reserved.");
    }

    public bool CheckAvailability()
    {
        return true; // Simulating availability
    }
}

// Magazine class inheriting from LibraryItem
class Magazine : LibraryItem
{
    public Magazine(int itemId, string title, string author) : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 7; // 1 week loan period
    }
}

// DVD class inheriting from LibraryItem
class DVD : LibraryItem, IReservable
{
    public DVD(int itemId, string title, string author) : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 3; // 3 days loan period
    }

    public void ReserveItem()
    {
        Console.WriteLine($"DVD '{Title}' has been reserved.");
    }

    public bool CheckAvailability()
    {
        return false;
    }
}

class Program
{
    static void Main()
    {
        LibraryItem book = new Book(101, "The Great Gatsby", "F. Scott Fitzgerald");
        book.GetItemDetails();
        Console.WriteLine($"Loan Duration: {book.GetLoanDuration()} days");

        Console.WriteLine();

        LibraryItem magazine = new Magazine(102, "National Geographic", "Various");
        magazine.GetItemDetails();
        Console.WriteLine($"Loan Duration: {magazine.GetLoanDuration()} days");

        Console.WriteLine();

        DVD dvd = new DVD(103, "Inception", "Christopher Nolan");
        dvd.GetItemDetails();
        Console.WriteLine($"Loan Duration: {dvd.GetLoanDuration()} days");
        dvd.ReserveItem();
        Console.WriteLine($"Availability: {dvd.CheckAvailability()}");
    }
}
