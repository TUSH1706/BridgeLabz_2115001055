using System;
using System.Collections.Generic;

public class StackSorter
{
    // Recursive function to sort the stack
    public static void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            // Pop the top element
            int temp = stack.Pop();

            // Sort the remaining stack
            SortStack(stack);

            // Insert the popped element back in sorted order
            InsertInSortedOrder(stack, temp);
        }
    }

    // Recursive function to insert an element in sorted order
    private static void InsertInSortedOrder(Stack<int> stack, int element)
    {
        // Base case: if the stack is empty or the element is greater than the top element
        if (stack.Count == 0 || element > stack.Peek())
        {
            stack.Push(element);
        }
        else
        {
            // Pop the top element
            int temp = stack.Pop();

            // Recursively insert the element in the sorted stack
            InsertInSortedOrder(stack, element);

            // Push the popped element back
            stack.Push(temp);
        }
    }

    // Helper function to print the stack
    public static void PrintStack(Stack<int> stack)
    {
        foreach (int item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(34);
        stack.Push(3);
        stack.Push(31);
        stack.Push(98);
        stack.Push(92);
        stack.Push(23);

        Console.WriteLine("Original Stack:");
        StackSorter.PrintStack(stack);

        // Sort the stack
        StackSorter.SortStack(stack);

        Console.WriteLine("Sorted Stack:");
        StackSorter.PrintStack(stack);
    }
}