/*
 * Author: Easton Bolinger
 * Class: Drink.cs
 * Purpose: Creation of the Drink base class
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data 
{
    /// <summary>
    /// Class representing the base drink 
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Reference to the different sizes offered 
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;
        
        /// <summary>
        /// Price placeholder 
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Calories default 
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// if drink should have ice 
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Special instructions for preparing drink 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
