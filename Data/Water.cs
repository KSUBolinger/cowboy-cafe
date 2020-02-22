/*
 * Author: Easton Bolinger
 * Class: Water.cs
 * Purpose: Handles the attributes of the Water Drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class represetnign the water drink
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        /// <summary>
        /// Calories of the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// If the water should have a lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// IF the water should have ice
        /// </summary>
        public new bool Ice { get; set; } = true;

        /// <summary>
        /// Special Instructions for the preparation of the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Lemon != false) instructions.Add("Add Lemon");
                if (Ice != true) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        public override string ToString()
        {
            return Size.ToString() + " Water";
        }
    }
}
