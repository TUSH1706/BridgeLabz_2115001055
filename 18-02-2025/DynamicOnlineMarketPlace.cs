using System;
using System.Collections.Generic;

// Base class for product categories
public abstract class ProductCategory { }

public class BookCategory : ProductCategory { }
public class ClothingCategory : ProductCategory { }

// Generic Product class with type constraint
public class Product<T> where T : ProductCategory
{
    public string Name { get; set; }
    public double Price { get; set; }
    public T Category { get; set; }

    public Product(string name, double price, T category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public override string ToString()
    {
        return $"Product: {Name}, Price: {Price:C}, Category: {Category.GetType().Name}";
    }
}

public class Marketplace
{
    private List<object> products = new List<object>();

    public void AddProduct<T>(Product<T> product) where T : ProductCategory
    {
        products.Add(product);
    }

    public void DisplayProducts()
    {
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }

    // Generic method to apply discount
    public void ApplyDiscount<T>(T product, double percentage) where T : Product<ProductCategory>
    {
        product.Price -= product.Price * (percentage / 100);
    }
}

class Program
{
    static void Main()
    {
        var book = new Product<BookCategory>("C# Programming", 50.0, new BookCategory());
        var shirt = new Product<ClothingCategory>("T-Shirt", 20.0, new ClothingCategory());

        var marketplace = new Marketplace();
        marketplace.AddProduct(book);
        marketplace.AddProduct(shirt);

        Console.WriteLine("Before Discount:");
        marketplace.DisplayProducts();

        marketplace.ApplyDiscount(book, 10);
        marketplace.ApplyDiscount(shirt, 15);

        Console.WriteLine("After Discount:");
        marketplace.DisplayProducts();
    }
}
