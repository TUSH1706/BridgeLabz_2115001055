
using System;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class RoleAllowedAttribute : Attribute
{
    public string RequiredRole { get; }

    public RoleAllowedAttribute(string requiredRole)
    {
        RequiredRole = requiredRole;
    }

    public bool HasAccess(string userRole)
    {
        return userRole == RequiredRole;
    }
}

public class User
{
    public string Username { get; set; }
    public string UserRole { get; set; }

    public User(string username, string role)
    {
        Username = username;
        UserRole = role;
    }

    [RoleAllowed("ADMIN")]
    public void AdminMethod()
    {
        Console.WriteLine($"Access granted to {Username} with ADMIN role.");
    }

    public void InvokeMethod(string methodName)
    {
        var method = this.GetType().GetMethod(methodName);
        var roleAllowedAttribute = (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));

        if (roleAllowedAttribute != null)
        {
            if (roleAllowedAttribute.HasAccess(UserRole))
            {
                method.Invoke(this, null);
            }
            else
            {
                Console.WriteLine("Access Denied!");
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Simulate users with roles
        User adminUser = new User("AdminUser", "ADMIN");
        User guestUser = new User("GuestUser", "GUEST");

        // Test with ADMIN user (should succeed)
        Console.WriteLine("Admin User Access:");
        adminUser.InvokeMethod("AdminMethod");

        // Test with non-ADMIN user (should print Access Denied!)
        Console.WriteLine("\nGuest User Access:");
        guestUser.InvokeMethod("AdminMethod");
    }
}



