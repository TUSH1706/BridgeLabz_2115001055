using System;

class Trignometry
{
    static void Main(string[] args)
    {
        Console.Write("Enter the angle in degrees: ");
        double angleInDegrees = double.Parse(Console.ReadLine());

        double[] trigonometricValues = CalculateTrigonometricFunctions(angleInDegrees);

        Console.WriteLine("Sine: " + trigonometricValues[0]);
        Console.WriteLine("Cosine: " + trigonometricValues[1]);
        Console.WriteLine("Tangent: " + trigonometricValues[2]);
    }

    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        double angleInRadians = angle * Math.PI / 180;
        double sine = Math.Sin(angleInRadians);
        double cosine = Math.Cos(angleInRadians);
        double tangent = Math.Tan(angleInRadians);

        return new double[] { sine, cosine, tangent };
    }
}
