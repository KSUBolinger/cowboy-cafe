/*
 * Author: Easton Bolinger
 * Class: ChiliCheeseFries.cs
 * Purpose: Handles the attributes of the Chili Cheese Fries Side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Chili Cheese Fries side
    /// </summary>
    public class ChiliCheeseFries: Side
    {
        /// <summary>
        /// The price of the chili cheese fries 
        /// </summary>
        public override double Price
        {
            get
            {
                if(this.Size == Size.Small)
                {
                    return 1.99;
                }
                else if(this.Size == Size.Medium)
                {
                    return 2.99;
                }
                else
                {
                    return 3.99;
                }
            }
        }

        /// <summary>
        /// The calories of the chili cheese fries 
        /// </summary>
        public override uint Calories
        {
            get 
            {
                if(this.Size == Size.Small)
                {
                    return 433;
                }
                else if(this.Size == Size.Medium)
                {
                    return 524;
                }
                else
                {
                    return 610;
                }
            }
        }
    }
}
