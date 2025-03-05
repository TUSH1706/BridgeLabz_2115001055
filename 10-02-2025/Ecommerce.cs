using System;
using System.Collections.Generic;

abstract class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int productId, string name, double price)
    {
        ProductId = productId;
        Name = name;
        Price = price;
    }

    public abstract double CalculateDiscount();

    public void DisplayDetails()
    {
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price}");
    }
}

class Electronics : Product, ITaxable
{
    public Electronics(int productId, string name, double price) 
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.10;
    }

    public double CalculateTax()
    {
        return Price * 0.18;
    }

    public string GetTaxDetails()
    {
        return $"Tax for {Name}: {CalculateTax()}";
    }
}

class Clothing : Product, ITaxable
{
    public Clothing(int productId, string name, double price) 
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.15;
    }

    public double CalculateTax()
    {
        return Price * 0.05;
    }

    public string GetTaxDetails()
    {
        return $"Tax for {Name}: {CalculateTax()}";
    }
}

class Groceries : Product
{
    public Groceries(int productId, string name, double price) 
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return 0;
    }
}

interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

class ProductManager
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void DisplayAllProductDetails()
    {
        foreach (var product in products)
        {
            product.DisplayDetails();
            double discount = product.CalculateDiscount();
            double finalPrice = product.Price - discount;

            if (product is ITaxable taxableProduct)
            {
                double tax = taxableProduct.CalculateTax();
                finalPrice += tax;
                Console.WriteLine(taxableProduct.GetTaxDetails());
            }

            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Final Price: {finalPrice}");
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ProductManager manager = new ProductManager();

        Electronics electronics = new Electronics(1, "Laptop", 80000);
        Clothing clothing = new Clothing(2, "T-Shirt", 500);
        Groceries groceries = new Groceries(3, "Apple", 100);

        manager.AddProduct(electronics);
        manager.AddProduct(clothing);
        manager.AddProduct(groceries);

        manager.DisplayAllProductDetails();
    }
}
