/*
 * Author: Easton Bolinger
 * Class: Entree.cs
 * Purpose: Creation of the entree base class
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class represetning an entree 
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Get the price of the entree 
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Get the Calories of the entree 
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the Special Instructions of the entree 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
