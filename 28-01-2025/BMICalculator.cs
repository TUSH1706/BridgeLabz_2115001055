using System;

class BMICalculator
{
    static void Main(string[] args)
    {
        // 2D array to store weight, height, and BMI
        double[,] data = new double[10, 3];
        string[] bmiStatus = new string[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter the weight (kg) of person " + (i + 1) + ": ");
            data[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height (cm) of person " + (i + 1) + ": ");
            data[i, 1] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < 10; i++)
        {
            data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);
            bmiStatus[i] = DetermineBMIStatus(data[i, 2]);
        }
        Console.WriteLine("\nDetails of all persons:");
        Console.WriteLine("Weight (kg)\tHeight (cm)\tBMI\t\tStatus");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(string.Format("{0:F2}\t\t{1:F2}\t\t{2:F2}\t\t{3}", data[i, 0], data[i, 1], data[i, 2], bmiStatus[i]));
        }
    }
    static double CalculateBMI(double weight, double heightInCm)
    {
        double heightInMeters = heightInCm / 100.0; // Convert cm to meters
        return weight / (heightInMeters * heightInMeters);
    }
    static string DetermineBMIStatus(double bmi)
    {
        if (bmi < 18.5)
        {
            return "Underweight";
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            return "Normal weight";
        }
        else if (bmi >= 25 && bmi < 39.9)
        {
            return "Overweight";
        }
        else
        {
            return "Obese";
        }
    }
}
