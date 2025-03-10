using System;

class VotingEligibility
{
    static void Main(string [] args)
    {
        int[] ages = new int[10];
        for (int i = 0; i < ages.Length; i++)
        {
            while (true)
            {
                Console.Write("Enter the age of student " + (i + 1) + ": ");
                int age;
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    if (age < 0)
                    {
                        Console.WriteLine("Invalid age. Age cannot be negative. Please enter again.");
                    }
                    else
                    {
                        ages[i] = age;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }
        Console.WriteLine("\nVoting Eligibility Results:");
        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] >= 18)
            {
                Console.WriteLine("The student with the age " + ages[i] + " can vote.");
            }
            else
            {
                Console.WriteLine("The student with the age " + ages[i] + " cannot vote.");
            }
        }
    }
}
