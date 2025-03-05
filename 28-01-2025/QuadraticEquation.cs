using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.Write("Enter the coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        double[] roots = FindRoots(a, b, c);
        if (roots.Length == 2)
        {
            Console.WriteLine("The equation has two distinct roots:");
            Console.WriteLine("Root 1: " + roots[0]);
            Console.WriteLine("Root 2: " + roots[1]);
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine("The equation has one real root:");
            Console.WriteLine("Root: " + roots[0]);
        }
        else
        {
            Console.WriteLine("The equation has no real roots (delta < 0).");
        }
    }
    static double[] FindRoots(double a, double b, double c)
    {
        if (a == 0)
        {
            Console.WriteLine("This is not a quadratic equation (a cannot be 0).");
            return new double[0];
        }
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else
        {
            return new double[0]; // Return an empty array
        }
    }
}
