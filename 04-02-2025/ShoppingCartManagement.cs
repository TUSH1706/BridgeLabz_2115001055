using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartManagement
{
    public class Product
    {
        public static double Discount = 10.0; // Static discount percentage shared by all products
        private static int productCounter = 1; // Counter for unique Product IDs

        public readonly int ProductID; // Readonly ProductID, cannot be changed after assignment
        private string productName;
        private double price;
        private int quantity;

        public Product(string productName, double price, int quantity)
        {
            this.ProductID = productCounter++; // Assign unique ID and increment counter
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }

        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
            Console.WriteLine($"Discount updated to {Discount}%");
        }

        // Method to calculate final price after applying discount
        public double GetDiscountedPrice()
        {
            return price * quantity * (1 - Discount / 100);
        }

        public string GetProductDetails()
        {
            return $"Product ID: {ProductID}\nProduct Name: {productName}\nPrice: {price:C}\nQuantity: {quantity}\nDiscounted Price: {GetDiscountedPrice():C}";
        }

        public static void DisplayProductDetails(object obj)
        {
            if (obj is Product product)
            {
                Console.WriteLine(product.GetProductDetails());
            }
            else
            {
                Console.WriteLine("The object is not a Product.");
            }
        }
    }
}
