using System;
using System.Collections.Generic;
namespace SmartWarehouseManagementSystem
{
    public abstract class WarehouseItem
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public WarehouseItem(string name, int id, decimal price)
        {
            Name = name;
            Id = id;
            Price = price;
        }
        public abstract void DisplayDetails();
    }
    public class Electronics : WarehouseItem
    {
        public string Brand { get; set; }

        public Electronics(string name, int id, decimal price, string brand)
            : base(name, id, price)
        {
            Brand = brand;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Electronics: {Name}, ID: {Id}, Brand: {Brand}, Price: {Price:C}");
        }
    }
    public class Groceries : WarehouseItem
    {
        public DateTime ExpiryDate { get; set; }

        public Groceries(string name, int id, decimal price, DateTime expiryDate)
            : base(name, id, price)
        {
            ExpiryDate = expiryDate;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Groceries: {Name}, ID: {Id}, Expiry Date: {ExpiryDate.ToShortDateString()}, Price: {Price:C}");
        }
    }
    public class Furniture : WarehouseItem
    {
        public string Material { get; set; }

        public Furniture(string name, int id, decimal price, string material)
            : base(name, id, price)
        {
            Material = material;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Furniture: {Name}, ID: {Id}, Material: {Material}, Price: {Price:C}");
        }
    }
    public class Storage<T> where T : WarehouseItem
    {
        private List<T> _items = new List<T>();
        public void AddItem(T item)
        {
            _items.Add(item);
            Console.WriteLine($"Added {item.Name} to storage.");
        }
        public void DisplayAllItems()
        {
            Console.WriteLine("Items in Storage:");
            foreach (var item in _items)
            {
                item.DisplayDetails();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Storage<Electronics> electronicsStorage = new Storage<Electronics>();
            electronicsStorage.AddItem(new Electronics("Smartphone", 1, 599.99m, "Samsung"));
            electronicsStorage.AddItem(new Electronics("Laptop", 2, 1299.99m, "Dell"));
            electronicsStorage.DisplayAllItems();
            Console.WriteLine();
            Storage<Groceries> groceriesStorage = new Storage<Groceries>();
            groceriesStorage.AddItem(new Groceries("Apples", 3, 2.99m, DateTime.Now.AddDays(10)));
            groceriesStorage.AddItem(new Groceries("Milk", 4, 1.99m, DateTime.Now.AddDays(5)));
            groceriesStorage.DisplayAllItems();
            Console.WriteLine();
            Storage<Furniture> furnitureStorage = new Storage<Furniture>();
            furnitureStorage.AddItem(new Furniture("Chair", 5, 49.99m, "Wood"));
            furnitureStorage.AddItem(new Furniture("Table", 6, 199.99m, "Glass"));
            furnitureStorage.DisplayAllItems();
            Console.WriteLine();
            Storage<WarehouseItem> mixedStorage = new Storage<WarehouseItem>();
            mixedStorage.AddItem(new Electronics("Smartwatch", 7, 199.99m, "Apple"));
            mixedStorage.AddItem(new Groceries("Bread", 8, 1.49m, DateTime.Now.AddDays(3)));
            mixedStorage.AddItem(new Furniture("Sofa", 9, 499.99m, "Leather"));
            ProcessItems(mixedStorage);
        }

        // Method to process items using variance
        public static void ProcessItems(Storage<WarehouseItem> storage)
        {
            Console.WriteLine("Processing Mixed Items:");
            storage.DisplayAllItems();
        }
    }
}