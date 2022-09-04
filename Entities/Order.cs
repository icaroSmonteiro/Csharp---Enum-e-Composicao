using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Csharp_EnumEComposicao.Entities.Enums;


namespace Csharp_EnumEComposicao.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public Enum OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, Enum status, Client client)
        {
            Moment = moment;
            OrderStatus = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }
    }
}
