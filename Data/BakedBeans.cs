/*
 * Author: Easton Bolinger
 * Class: BakedBeans.cs
 * Purpose: Handles the attributes of the Baked Beans Side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// This class represents the Baked Beans side
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// Price of the Baked Beans
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
                    return 1.79;
                }
                else
                {
                    return 1.99;
                }
            }
        }

        /// <summary>
        /// Calories of the Baked Beans 
        /// </summary>
        public override uint Calories
        {
            get
            {
                if(this.Size == Size.Small)
                {
                    return 312;
                }
                else if(this.Size == Size.Medium)
                {
                    return 378;
                }
                else
                {
                    return 410;
                }
            }
        }
    }
}
