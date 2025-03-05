using System;

class BMI
{
    static void Main()
    {
        // Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int n = int.Parse(Console.ReadLine());
        double[] height = new double[n];
        double[] weight = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        // Take input for height and weight of each person
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nPerson " + (i + 1) + ":");
            Console.Write("Enter height in meters: ");
            height[i] = double.Parse(Console.ReadLine());
            Console.Write("Enter weight in kilograms: ");
            weight[i] = double.Parse(Console.ReadLine());
            bmi[i] = weight[i] / (height[i] * height[i]);
            if (bmi[i] < 18.5)
            {
                status[i] = "Underweight";
            }
            else if (bmi[i] >= 18.5 && bmi[i] < 24.9)
            {
                status[i] = "Normal weight";
            }
            else if (bmi[i] >= 25 && bmi[i] < 29.9)
            {
                status[i] = "Overweight";
            }
            else
            {
                status[i] = "Obesity";
            }
        }
        Console.WriteLine("\nPerson Details:");
        Console.WriteLine("Person | Height (m) | Weight (kg) | BMI    | Status");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(String.Format("{0,6} | {1,11:F2} | {2,12:F2} | {3,6:F2} | {4}", i + 1, height[i], weight[i], bmi[i], status[i]));
        }
    }
}
