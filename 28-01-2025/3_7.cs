using System;

class OTPGenerator
{
    // Method to generate a 6-digit OTP using Math.Random
    public static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000);
    }

    // Method to ensure the OTPs are unique
    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                    return false;
            }
        }
        return true;
    }

    public static void MainOTP()
    {
        int[] otps = new int[10];

        // Generate OTPs
        for (int i = 0; i < otps.Length; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine($"Generated OTP {i + 1}: {otps[i]}");
        }

        // Validate uniqueness
        bool unique = AreOTPsUnique(otps);
        Console.WriteLine("Are all OTPs unique? " + (unique ? "Yes" : "No"));
    }
}
