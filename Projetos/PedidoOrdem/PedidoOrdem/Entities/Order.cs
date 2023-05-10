using PedidoOrdem.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PedidoOrdem.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Clien { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client cl)
        {
            Moment = moment;
            Status = status;
            Clien = cl;
        }
        public void AddItem(OrderItem item) { Items.Add(item); }
        public void RemoveItem(OrderItem item) { Items.Remove(item); }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client:");
            sb.Append(Clien.Name);
            sb.Append(" (");
            sb.Append(Clien.BirthDate.ToString());
            sb.Append(") - ");
            sb.AppendLine(Clien.Email);
            sb.AppendLine("Order Items:");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total Price: ");
            double total = Total();
            sb.AppendLine("$" + total.ToString("F2", CultureInfo.InvariantCulture)) ;
            
            return sb.ToString();
        }
    }
}
