using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order
    {
        /// <summary>
        /// gives the order number from last order
        /// </summary>
        private uint lastOrderNumber = 1;
        /// <summary>
        /// creaetes a list for items in new order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// creates an array of the same size and type of items
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        private double subtotal;
        /// <summary>
        /// creates a subtotal
        /// </summary>
        public double Subtotal => subtotal;

        /// <summary>
        /// increases order number by one
        /// </summary>
        public uint OrderNumber => lastOrderNumber++;

        /// <summary>
        /// handles when properties have been changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// adds an item and it's order to the list of items in an order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item) 
        {
            items.Add(item);
            subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            
        }

        /// <summary>
        /// Removes an item and its price from the list of items 
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
        /// <summary>
        /// a string representing the order number 
        /// </summary>
        public string OrderString => "Order " + OrderNumber.ToString();
    }
}
