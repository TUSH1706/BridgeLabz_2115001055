using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_2_2025
{
    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        private static int totalProducts = 0;

        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
            totalProducts++;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}, Price: ${Price}");
        }

        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products Created: {totalProducts}");
        }
    }
}
