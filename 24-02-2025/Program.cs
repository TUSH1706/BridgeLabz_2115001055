using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Suppress the warning about using ArrayList without generics
        #pragma warning disable 0618  // Disables the warning for using non-generic collections

        // Creating an ArrayList (non-generic)
        ArrayList list = new ArrayList();

        // Adding items to the ArrayList
        list.Add("Hello");
        list.Add(123);
        list.Add(45.67);

        // Displaying the elements
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Re-enable the warning (optional)
        #pragma warning restore 0618
    }
}

