using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePlatform
{
    public class Product
    {
        public string name;
        public double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }

    public class Order
    {
        public string ordId;
        public Custom customer;
        private List<Product> products;

        public Order(string ordId, Custom customer)
        {
            this.ordId = ordId;
            this.customer = customer;
            products = new List<Product>();
        }

        public void addProduct(Product product)
        {
            products.Add(product);
        }

        public double getPrice()
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.price;
            }
            return totalPrice;
        }

        public void showOrderDetails()
        {
            Console.WriteLine($"Order ID: {ordId}");
            Console.WriteLine($"Customer: {customer.name}");
            Console.WriteLine("Products in Order:");
            foreach (var product in products)
            {
                Console.WriteLine($"  Product: {product.name}, Price: {product.price} Rs.");
            }
            Console.WriteLine($"Total Price: {getPrice()} Rs.");
        }
    }

    
    public class Custom
    {
        public string name;
        private List<Order> orders;

        public Custom(string name)
        {
            this.name = name;
            orders = new List<Order>();
        }

        public void placeOrder(Order order)
        {
            orders.Add(order);
        }

        public void showOrders()
        {
            Console.WriteLine($"Customer: {name} has placed the following orders:");
            foreach (var order in orders)
            {
                order.showOrderDetails();
            }
        }

    }
}
