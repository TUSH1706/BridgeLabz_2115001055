using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRetailOrderManagement
{
    public class Order
    {
        public string orderId;
        public DateTime orderDate;

        public Order(string orderId, DateTime orderDate)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
        }

        public virtual string GetOrderStatus()
        {
            return "Order Placed";
        }


    }

    class ShippedOrder : Order
    {
        public int trackingNumber;

        public ShippedOrder(string orderId, DateTime orderDate, int trackingNumber) : base(orderId, orderDate)
        {
            this.trackingNumber = trackingNumber;
        }

        public override string GetOrderStatus()
        {
            return "Order Shipped";
        }


    }

    class DeliveredOrder : ShippedOrder
    {
        public DateTime deliveryDate;

        public DeliveredOrder(string orderId, DateTime orderDate, int trackingNumber, DateTime deliveryDate) : base(orderId, orderDate, trackingNumber)
        {
            this.deliveryDate = deliveryDate;
        }

        public override string GetOrderStatus()
        {
            return "Order Delivered";
        }


    }

}
