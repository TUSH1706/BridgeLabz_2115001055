using System;

class BMI
{
    static void Main()
    {
        Console.Write("Enter the number of persons: ");
        int number = int.Parse(Console.ReadLine());
        
        double[][] personData = new double[number][];
        for (int i = 0; i < number; i++)
        {
            personData[i] = new double[3];
        }
        string[] weightStatus = new string[number];

        for (int i = 0; i < number; i++)
        {
            double height = -1, weight = -1;

            while (height <= 0)
            {
                Console.WriteLine("\nPerson " + (i + 1) + ":");
                Console.Write("Enter height in meters (positive value): ");
                height = double.Parse(Console.ReadLine());
                if (height <= 0)
                {
                    Console.WriteLine("Height must be a positive number.");
                }
            }

            while (weight <= 0)
            {
                Console.Write("Enter weight in kilograms (positive value): ");
                weight = double.Parse(Console.ReadLine());
                if (weight <= 0)
                {
                    Console.WriteLine("Weight must be a positive number.");
                }
            }
            personData[i][0] = height;
            personData[i][1] = weight;
            personData[i][2] = weight / (height * height);

            if (personData[i][2] < 18.5)
            {
                weightStatus[i] = "Underweight";
            }
            else if (personData[i][2] >= 18.5 && personData[i][2] < 24.9)
            {
                weightStatus[i] = "Normal weight";
            }
            else if (personData[i][2] >= 25 && personData[i][2] < 29.9)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obesity";
            }
        }
        Console.WriteLine("\nPerson Details:");
        Console.WriteLine("Person | Height (m) | Weight (kg) | BMI    | Status");

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(String.Format("{0,6} | {1,11:F2} | {2,12:F2} | {3,6:F2} | {4}",
                i + 1, personData[i][0], personData[i][1], personData[i][2], weightStatus[i]));
        }
    }
}