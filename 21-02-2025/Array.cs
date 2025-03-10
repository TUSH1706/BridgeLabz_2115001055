using System;

class Array
{
    static void Main()
    {
        int[] numbers = null;
        
        try
        {
            Console.Write("Enter the number of elements: ");
            int size = Convert.ToInt32(Console.ReadLine());
            numbers = new int[size];
            
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter index to retrieve value: ");
            int index = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Value at index " +index ,numbers[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid numeric value.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred:" +ex.Message);
        }
    }
}