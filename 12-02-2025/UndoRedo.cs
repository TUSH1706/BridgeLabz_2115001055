using System;
using System.Collections.Generic;

class TextState
{
    public string Content;
    public TextState Prev;
    public TextState Next;

    public TextState(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private TextState currentState;
    private int maxHistory;
    private int historySize;

    public TextEditor(int historyLimit = 10)
    {
        currentState = new TextState("");
        maxHistory = historyLimit;
        historySize = 1;
    }

    public void AddState(string newText)
    {
        TextState newState = new TextState(newText);
        newState.Prev = currentState;
        currentState.Next = newState;
        currentState = newState;
        historySize++;
        
        if (historySize > maxHistory)
        {
            TextState temp = currentState;
            while (temp.Prev != null && historySize > maxHistory)
            {
                temp = temp.Prev;
                historySize--;
            }
            temp.Prev = null;
        }
    }

    public void Undo()
    {
        if (currentState.Prev != null)
        {
            currentState = currentState.Prev;
            Console.WriteLine("Undo: " + currentState.Content);
        }
        else
        {
            Console.WriteLine("No previous state to undo.");
        }
    }

    public void Redo()
    {
        if (currentState.Next != null)
        {
            currentState = currentState.Next;
            Console.WriteLine("Redo: " + currentState.Content);
        }
        else
        {
            Console.WriteLine("No next state to redo.");
        }
    }

    public void DisplayCurrentState()
    {
        Console.WriteLine("Current Text: " + currentState.Content);
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();
        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.DisplayCurrentState();
        editor.Undo();
        editor.Redo();
    }
}