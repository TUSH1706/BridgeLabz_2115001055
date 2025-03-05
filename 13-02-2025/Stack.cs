using System;
using System.Collections.Generic;

public class QueueUsingStacks
{
    private Stack<int> enqueueStack;
    private Stack<int> dequeueStack;

    public QueueUsingStacks()
    {
        enqueueStack = new Stack<int>();
        dequeueStack = new Stack<int>();
    }

    // Enqueue operation
    public void Enqueue(int item)
    {
        // Push the item onto the enqueue stack
        enqueueStack.Push(item);
    }

    // Dequeue operation
    public int Dequeue()
    {
        // If the dequeue stack is empty, transfer elements from the enqueue stack
        if (dequeueStack.Count == 0)
        {
            while (enqueueStack.Count > 0)
            {
                dequeueStack.Push(enqueueStack.Pop());
            }
        }

        // If the dequeue stack is still empty, the queue is empty
        if (dequeueStack.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        // Pop and return the item from the dequeue stack
        return dequeueStack.Pop();
    }

    // Peek operation
    public int Peek()
    {
        if (dequeueStack.Count == 0)
        {
            while (enqueueStack.Count > 0)
            {
                dequeueStack.Push(enqueueStack.Pop());
            }
        }
        if (dequeueStack.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        return dequeueStack.Peek();
    }

    // Check if the queue is empty
    public bool IsEmpty()
    {
        return enqueueStack.Count == 0 && dequeueStack.Count == 0;
    }
}

public class Program
{
    public static void Main()
    {
        QueueUsingStacks queue = new QueueUsingStacks();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Peek());   
        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.IsEmpty()); 
        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.IsEmpty());  
    }
}