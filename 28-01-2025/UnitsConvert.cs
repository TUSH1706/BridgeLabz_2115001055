using System;

class UnitConvert
{
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }
    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }
    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }
    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }
    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }

    public static void Main(string[] args)
    {
        double yards = 5;
        Console.WriteLine(yards + " yards = " + UnitConverter.ConvertYardsToFeet(yards) + " feet");
        double feet = 15;
        Console.WriteLine(feet + " feet = " + UnitConverter.ConvertFeetToYards(feet) + " yards");
	}
}
