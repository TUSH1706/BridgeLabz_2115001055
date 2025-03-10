using System;
abstract class FoodItem
{
    public string ItemName { get; private set; }
    public double Price { get; private set; }
    public int Quantity { get; private set; }

    public FoodItem(string itemName, double price, int quantity)
    {
        ItemName = itemName;
        Price = price;
        Quantity = quantity;
    }

    public abstract double CalculateTotalPrice();

    public void GetItemDetails()
    {
        Console.WriteLine($"Item: {ItemName}, Price: {Price:C}, Quantity: {Quantity}");
    }
}
interface IDiscountable
{
    void ApplyDiscount(double percentage);
    void GetDiscountDetails();
}

// VegItem class inheriting from FoodItem
class VegItem : FoodItem, IDiscountable
{
    private double discount;

    public VegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return (Price * Quantity) - discount;
    }

    public void ApplyDiscount(double percentage)
    {
        discount = (Price * Quantity) * (percentage / 100);
    }

    public void GetDiscountDetails()
    {
        Console.WriteLine($"Discount applied: {discount:C}");
    }
}

// NonVegItem class inheriting from FoodItem
class NonVegItem : FoodItem, IDiscountable
{
    private const double AdditionalCharge = 1.5; // Extra charge per item
    private double discount;

    public NonVegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return ((Price + AdditionalCharge) * Quantity) - discount;
    }

    public void ApplyDiscount(double percentage)
    {
        discount = ((Price + AdditionalCharge) * Quantity) * (percentage / 100);
    }

    public void GetDiscountDetails()
    {
        Console.WriteLine($"Discount applied: {discount:C}");
    }
}

class Program
{
    static void Main()
    {
        FoodItem vegBurger = new VegItem("Veg Burger", 5.0, 2);
        vegBurger.GetItemDetails();
        Console.WriteLine($"Total Price: {vegBurger.CalculateTotalPrice():C}");

        Console.WriteLine();

        NonVegItem chickenBurger = new NonVegItem("Chicken Burger", 7.0, 3);
        chickenBurger.GetItemDetails();
        chickenBurger.ApplyDiscount(10);
        chickenBurger.GetDiscountDetails();
        Console.WriteLine($"Total Price after Discount: {chickenBurger.CalculateTotalPrice():C}");
    }
}
