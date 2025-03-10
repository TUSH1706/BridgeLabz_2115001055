
using System;

public class LegacyAPI
{
    // Marking OldFeature() as obsolete using the Obsolete attribute
    [Obsolete("OldFeature() is deprecated. Use NewFeature() instead.")]
    public void OldFeature()
    {
        Console.WriteLine("Executing old feature...");
    }

    // New method to replace the old feature
    public void NewFeature()
    {
        Console.WriteLine("Executing new feature...");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of LegacyAPI
        LegacyAPI legacyAPI = new LegacyAPI();

        // Calling the old method (this will show a warning)
        legacyAPI.OldFeature();  // Warning: 'OldFeature' is obsolete

        // Calling the new method
        legacyAPI.NewFeature();  // This works without a warning
    }
}


