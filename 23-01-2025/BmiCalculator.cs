using System;

class BMI_Calculator
{
    static void Main(string[] args)
    {
		//Weight (in kg) and Height
        Console.Write("Enter weight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height in cm: ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());

       
        double heightInMeters = heightInCm / 100;

        
        double bmi = weight / (heightInMeters * heightInMeters);

        
        Console.WriteLine("Your BMI is: " + Math.Round(bmi, 2));

       
        if (bmi < 18.5)
        {
            Console.WriteLine("You are underweight.");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("You have a normal weight.");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("You are overweight.");
        }
        else
        {
            Console.WriteLine("You are obese.");
        }
    }
}
