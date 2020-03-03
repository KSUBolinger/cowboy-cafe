using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order
    {
        private uint lastOrderNumber = 1;
        private List<IOrderItem> items = new List<IOrderItem>();
        public IEnumerable<IOrderItem> Items => items.ToArray();

        private double subtotal;
        public double Subtotal => subtotal;

        public uint OrderNumber => lastOrderNumber++;

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(IOrderItem item) 
        {
            items.Add(item);
            subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            
        }

        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
        public string OrderString => "Order " + OrderNumber.ToString();
    }
}
