using System;
using System.Collections.Generic;
using _003_ex.Entities.Enums;

namespace _003_ex.Entities
{
    class Order
    {
        private DateTime moment = DateTime.Now;
        OrderStatus status;
        public Client client { get; set; }
        private List<OrderItem> orderItems = new List<OrderItem>();

        public Order() { }

        public Order(OrderStatus status, Client client)
        {
            this.status = status;
            this.client = client;
        }

        public void OrderStatusUpdate(OrderStatus newStatus)
        {
            status = newStatus;
        }

        public void addItem(OrderItem item)
        {
            orderItems.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            orderItems.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach(OrderItem item in orderItems)
            {
                total += item.subTotal();
            }
            return total;
        }

        public override string ToString()
        {
            return "$ Order moment: " + moment.ToString("dd/MM/yyyy HH:mm:ss") + "\n" +
                "$ Order status: " + status + "\n" +
                "$ Client: " + client + "\n" +
                "$ Order items:\n" +
                "$ " + string.Join("\n$ ", orderItems) + "\n" +
                "$ Total price: $" + Total().ToString("F2") + "\n";
        }

    }
}
