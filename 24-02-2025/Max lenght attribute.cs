
using System;

// Define the MaxLength attribute
[AttributeUsage(AttributeTargets.Field, Inherited = false)]
public class MaxLengthAttribute : Attribute
{
    // Property to store the maximum allowed length
    public int Length { get; }

    // Constructor to initialize the maximum length value
    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}

using System;
using System.Reflection;

public class User
{
    // Apply MaxLength attribute to the Username field
    [MaxLength(20)]
    public string Username { get; }

    // Constructor to validate Username length
    public User(string username)
    {
        // Get the MaxLength attribute applied to the Username field
        var maxLengthAttribute = (MaxLengthAttribute)Attribute.GetCustomAttribute(
            typeof(User).GetField("Username"),
            typeof(MaxLengthAttribute));

        if (maxLengthAttribute != null)
        {
            // Check if the length of the username exceeds the max length
            if (username.Length > maxLengthAttribute.Length)
            {
                throw new ArgumentException($"Username cannot be longer than {maxLengthAttribute.Length} characters.");
            }
        }

        // Set the username value
        Username = username;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Try to create a User with a valid username
            User user1 = new User("ValidUsername");
            Console.WriteLine($"User created with Username: {user1.Username}");

            // Try to create a User with a too long username
            User user2 = new User("ThisUsernameIsWayTooLong");
            Console.WriteLine($"User created with Username: {user2.Username}");
        }
        catch (ArgumentException ex)
        {
            // Catch and display the validation exception
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

