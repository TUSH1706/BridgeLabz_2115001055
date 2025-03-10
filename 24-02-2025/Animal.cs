
using System;

public class Animal
{
    // Parent class method
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }
}

public class Dog : Animal
{
    // Overriding the MakeSound method in the Dog class
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Dog
        Dog myDog = new Dog();
        
        // Calling the overridden method
        myDog.MakeSound();  // This will print "Bark"
    }
}


