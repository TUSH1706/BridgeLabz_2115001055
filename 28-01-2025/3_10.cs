using System;

class Program
{
    // Method to check if three points are collinear using the slope formula
    static bool ArePointsCollinearSlope(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        // Calculate the slopes
        double slopeAB = (double)(y2 - y1) / (x2 - x1);
        double slopeBC = (double)(y3 - y2) / (x3 - x2);
        double slopeAC = (double)(y3 - y1) / (x3 - x1);

        // Check if slopes are equal
        return slopeAB == slopeBC && slopeAB == slopeAC;
    }

    // Method to check if three points are collinear using the area of triangle formula
    static bool ArePointsCollinearArea(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        // Calculate the area of the triangle formed by the three points
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

        // If the area is 0, the points are collinear
        return area == 0;
    }

    static void Main()
    {
        // Input the coordinates of three points
        Console.WriteLine("Enter the coordinates of point A (x1, y1): ");
        string[] pointA = Console.ReadLine().Split();
        int x1 = int.Parse(pointA[0]);
        int y1 = int.Parse(pointA[1]);

        Console.WriteLine("Enter the coordinates of point B (x2, y2): ");
        string[] pointB = Console.ReadLine().Split();
        int x2 = int.Parse(pointB[0]);
        int y2 = int.Parse(pointB[1]);

        Console.WriteLine("Enter the coordinates of point C (x3, y3): ");
        string[] pointC = Console.ReadLine().Split();
        int x3 = int.Parse(pointC[0]);
        int y3 = int.Parse(pointC[1]);

        // Check if the points are collinear using the slope formula
        if (ArePointsCollinearSlope(x1, y1, x2, y2, x3, y3))
        {
            Console.WriteLine("The points are collinear using the slope formula.");
        }
        else
        {
            Console.WriteLine("The points are not collinear using the slope formula.");
        }

        // Check if the points are collinear using the area of triangle formula
        if (ArePointsCollinearArea(x1, y1, x2, y2, x3, y3))
        {
            Console.WriteLine("The points are collinear using the area of triangle formula.");
        }
        else
        {
            Console.WriteLine("The points are not collinear using the area of triangle formula.");
        }
    }
}
