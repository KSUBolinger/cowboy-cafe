/*
 * Author: Easton Bolinger
 * Class: PanDeCampo.cs
 * Purpose: Handles the attributes of the Pan De Campo Side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class representing the Pan de Campo side
    /// </summary>
    public class PanDeCampo : Side
    {
        /// <summary>
        /// Price of the Pan de Campo side
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
        /// The calories of the Pan de Campo side
        /// </summary>
        public override uint Calories
        {
            get
            {
                if(this.Size == Size.Small)
                {
                    return 227;
                }
                else if(this.Size == Size.Medium)
                {
                    return 269;
                }
                else
                {
                    return 367;
                }
            }
        }
    }
}
