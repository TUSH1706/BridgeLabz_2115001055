using System;

class GeometryCalculator
{
    // Method to calculate the Euclidean distance between two points
    public static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    // Method to calculate the equation of the line given two points
    public static double[] CalculateLineEquation(double x1, double y1, double x2, double y2)
    {
        // Array to store slope (m) and y-intercept (b)
        double[] lineEquation = new double[2];
        
        // Calculate slope m
        double m = (y2 - y1) / (x2 - x1);
        lineEquation[0] = m;

        // Calculate y-intercept b
        double b = y1 - m * x1;
        lineEquation[1] = b;

        return lineEquation;
    }

    // Main method
    public static void Main(string[] args)
    {
        // Input for two points
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        // Calculate distance
        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine($"\nEuclidean Distance between ({x1}, {y1}) and ({x2}, {y2}) is: {distance:F2}");

        // Calculate line equation
        double[] lineEquation = CalculateLineEquation(x1, y1, x2, y2);
        Console.WriteLine($"The equation of the line passing through ({x1}, {y1}) and ({x2}, {y2}) is:");
        Console.WriteLine($"y = {lineEquation[0]:F2}x + {lineEquation[1]:F2}");
    }
}
