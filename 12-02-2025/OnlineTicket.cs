using System;
using System.Collections.Generic;

class Ticket
{
    public int TicketID;
    public string CustomerName;
    public string MovieName;
    public string SeatNumber;
    public DateTime BookingTime;
    public Ticket Next;

    public Ticket(int ticketID, string customerName, string movieName, string seatNumber)
    {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = DateTime.Now;
        Next = null;
    }
}

class TicketReservationSystem
{
    private Ticket head;
    private Ticket tail;
    private int ticketCount;

    public TicketReservationSystem()
    {
        head = tail = null;
        ticketCount = 0;
    }

    public void AddTicket(int ticketID, string customerName, string movieName, string seatNumber)
    {
        Ticket newTicket = new Ticket(ticketID, customerName, movieName, seatNumber);
        if (head == null)
        {
            head = tail = newTicket;
            tail.Next = head;
        }
        else
        {
            tail.Next = newTicket;
            tail = newTicket;
            tail.Next = head;
        }
        ticketCount++;
    }

    public void RemoveTicket(int ticketID)
    {
        if (head == null) return;
        Ticket temp = head, prev = null;
        do
        {
            if (temp.TicketID == ticketID)
            {
                if (prev != null)
                    prev.Next = temp.Next;
                else
                    head = head.Next;
                if (temp == tail)
                    tail = prev;
                ticketCount--;
                Console.WriteLine("Ticket " + ticketID + " removed.");
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);
    }

    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets available.");
            return;
        }
        Ticket temp = head;
        do
        {
            Console.WriteLine("Ticket ID: " + temp.TicketID + ", Customer: " + temp.CustomerName + ", Movie: " + temp.MovieName + ", Seat: " + temp.SeatNumber + ", Time: " + temp.BookingTime);
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchTicket(string query)
    {
        Ticket temp = head;
        do
        {
            if (temp.CustomerName.Contains(query) || temp.MovieName.Contains(query))
            {
                Console.WriteLine("Ticket Found - ID: " + temp.TicketID + ", Customer: " + temp.CustomerName + ", Movie: " + temp.MovieName + ", Seat: " + temp.SeatNumber + ", Time: " + temp.BookingTime);
            }
            temp = temp.Next;
        } while (temp != head);
    }

    public int GetTotalTickets()
    {
        return ticketCount;
    }
}

class Program
{
    static void Main()
    {
        TicketReservationSystem system = new TicketReservationSystem();
        system.AddTicket(1, "Alice", "Inception", "A1");
        system.AddTicket(2, "Bob", "Interstellar", "B2");
        system.DisplayTickets();
        system.SearchTicket("Inception"); Console.WriteLine("Total Tickets: " + system.GetTotalTickets()); system.RemoveTicket(1); system.DisplayTickets(); 
		} 
}