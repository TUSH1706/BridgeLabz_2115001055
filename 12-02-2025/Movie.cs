using System;

class MovieNode
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public MovieNode Prev;
    public MovieNode Next;

    public MovieNode(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Prev = null;
        Next = null;
    }
}

class MovieDoublyLinkedList
{
    private MovieNode head;
    private MovieNode tail;

    public void AddMovie(string title, string director, int year, double rating, int? position = null)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);
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
            MovieNode temp = head;
            int count = 0;
            while (temp.Next != null && count < position - 1)
            {
                temp = temp.Next;
                count++;
            }
            newNode.Next = temp.Next;
            newNode.Prev = temp;
            if (temp.Next != null)
                temp.Next.Prev = newNode;
            temp.Next = newNode;
            if (newNode.Next == null)
                tail = newNode;
        }
    }

    public void RemoveMovie(string title)
    {
        MovieNode temp = head;
        while (temp != null && temp.Title != title)
            temp = temp.Next;
        if (temp == null)
        {
            Console.WriteLine("Movie not found!");
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
        Console.WriteLine("Movie removed successfully.");
    }

    public void SearchMovie(string director, double? rating = null)
    {
        MovieNode temp = head;
        while (temp != null)
        {
            if (temp.Director == director || (rating != null && temp.Rating == rating))
                Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.Next;
        }
    }

    public void UpdateRating(string title, double newRating)
    {
        MovieNode temp = head;
        while (temp != null && temp.Title != title)
            temp = temp.Next;
        if (temp != null)
        {
            temp.Rating = newRating;
            Console.WriteLine("Rating updated successfully.");
        }
        else
        {
            Console.WriteLine("Movie not found!");
        }
    }

    public void DisplayMovies()
    {
        MovieNode temp = head;
        Console.WriteLine("Movies in forward order:");
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.Next;
        }
    }

    public void DisplayMoviesReverse()
    {
        MovieNode temp = tail;
        Console.WriteLine("Movies in reverse order:");
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.Prev;
        }
    }
}

class Program
{
    static void Main()
    {
        MovieDoublyLinkedList movies = new MovieDoublyLinkedList();
		movies.AddMovie("Inception", "Christopher Nolan", 2010, 8.8);
		movies.AddMovie("The Godfather", "Francis Ford Coppola", 1972, 9.2, position: 1);
		movies.AddMovie("Pulp Fiction", "Quentin Tarantino", 1994, 8.9, position: 2);
        movies.DisplayMovies();
        movies.UpdateRating("The Matrix", 9.0);
        movies.DisplayMovies();
        movies.RemoveMovie("Inception");
        movies.DisplayMovies();
        movies.DisplayMoviesReverse();
    }
}
