/*
 * Author: Easton Bolinger
 * Class: CowboyCoffee.cs
 * Purpose: To handle the attributes of the Cowboy Coffee Drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class represetning the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// Price of the Cowboy Coffee
        /// </summary>
        public override double Price
        {
            get
            {
                if(this.Size == Size.Small)
                {
                    return 0.60;
                }
                else if(this.Size == Size.Medium)
                {
                    return 1.10;
                }
                else
                {
                    return 1.60;
                }
            }
        }
        
        /// <summary>
        /// Calories of the Cowboy Coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                if(this.Size == Size.Small)
                {
                    return 3;
                }
                else if(this.Size == Size.Small)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>
        /// Whether or not the coffee has ice
        /// </summary>
        public bool Ice
        {
            get { return false; }
            set { Ice = value; }
        }


        private bool Cream = false;
        /// <summary>
        /// If the coffee has room for cream 
        /// </summary>
        public bool RoomForCream
        {
            get { return Cream; }
            set { Cream = value; }
        }

        /// <summary>
        /// Special instructions for the preparation of the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Add Ice");
                if (!Cream) instructions.Add("Room for Cream");

                return instructions;
            }
        }
    }
}
