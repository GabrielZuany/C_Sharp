using System;
using _001.Entities;
using _001.Entities.Enums;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Date = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            // Convert enum to string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // Convert string to enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}