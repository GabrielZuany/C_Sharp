using System;
using System.Collections.Generic;
using _001.Entities.Enums;

namespace _001.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Date: {Date}, Status: {Status}";
        }
    }
}
