/*
 * Author: Easton Bolinger
 * Class: JerkedSoda.cs
 * Purpose: To handle the attributes of the Jerked Soda Drink 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda Drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// price of the jerked soda
        /// </summary>
        public override double Price
        {
            get
            {
                if(this.Size == Size.Small)
                {
                    return 1.59;
                }
                else if(this.Size == Size.Medium)
                {
                    return 2.10;
                }
                else
                {
                    return 2.59;
                }
            }
        }

        /// <summary>
        /// calories of the jerked soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                if(this.Size == Size.Small)
                {
                    return 110;
                }
                else if(this.Size == Size.Medium)
                {
                    return 146;
                }
                else
                {
                    return 198;
                }
            }
        }

        /// <summary>
        /// The flavor of the Jerked Soda 
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// Special Instructions for the prepration of the jerked soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        public override string ToString()
        {
            
            return Size.ToString() + " " + Flavor.ToString() +  " Jerked Soda";
        }
    }
}
