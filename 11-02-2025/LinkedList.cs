using System;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        this.Data = data;
        this.Next = null;
    }
}

public class LinkedList
{
    private Node head;

    public LinkedList()
    {
        this.head = null;
    }

    // Print the linked list
    public void PrintList()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("None");
    }

    // Add a node at the beginning
    public void AddFirst(int newData)
    {
        Node newNode = new Node(newData);
        newNode.Next = head;
        head = newNode;
    }

    // Add a node in between
    public void AddBetween(Node prevNode, int newData)
    {
        if (prevNode == null)
        {
            Console.WriteLine("Previous node must be in LinkedList");
            return;
        }
        Node newNode = new Node(newData);
        newNode.Next = prevNode.Next;
        prevNode.Next = newNode;
    }

    // Add a node at the end
    public void AddLast(int newData)
    {
        Node newNode = new Node(newData);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node last = head;
        while (last.Next != null)
        {
            last = last.Next;
        }
        last.Next = newNode;
    }

    // Delete the first node
    public void DeleteFirst()
    {
        if (head == null)
        {
            return;
        }
        head = head.Next;
    }

    // Delete the last node
    public void DeleteLast()
    {
        if (head == null)
        {
            return;
        }
        if (head.Next == null)
        {
            head = null;
            return;
        }
        Node secondLast = head;
        while (secondLast.Next.Next != null)
        {
            secondLast = secondLast.Next;
        }
        secondLast.Next = null;
    }

    // Delete a node by value
    public void DeleteNode(int key)
    {
        Node current = head;
        Node prev = null;

        if (current != null && current.Data == key)
        {
            head = current.Next;
            return;
        }

        while (current != null && current.Data != key)
        {
            prev = current;
            current = current.Next;
        }

        if (current == null) 
        {
            return;
        }

        prev.Next = current.Next;
    }

    // Delete a node at a given position
    public void DeleteAtPosition(int position)
    {
        if (head == null)
        {
            return;
        }

        Node temp = head;

        if (position == 0)
        {
            head = temp.Next;
            return;
        }

        for (int i = 0; temp != null && i < position - 1; i++)
        {
            temp = temp.Next;
        }

        if (temp == null || temp.Next == null)
        {
            return;
        }

        Node next = temp.Next.Next;
        temp.Next = next;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        LinkedList llist = new LinkedList();
        llist.AddFirst(1);
        llist.AddLast(2);
        llist.AddBetween(llist.head, 3);
        llist.PrintList();
        llist.DeleteFirst();
        llist.PrintList();
        llist.DeleteLast();
        llist.PrintList();
        llist.DeleteNode(3);
        llist.PrintList();
        llist.AddFirst(4);
        llist.AddLast(5);
        llist.AddBetween(llist.head.Next, 6);
        llist.PrintList();
        llist.DeleteAtPosition(1);
        llist.PrintList();
    }
}
