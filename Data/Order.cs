﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order
    {
        private uint lastOrderNumber;
        private List<IOrderItem> items = new List<IOrderItem>();
        public IEnumerable<IOrderItem> Items => items;

        private double subtotal;
        public double Subtotal => subtotal;

        public uint OrderNumber { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(IOrderItem item) 
        {
            items.Add(item);
            subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
