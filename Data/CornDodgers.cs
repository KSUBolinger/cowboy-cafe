/*
 * Author: Easton Bolinger
 * Class: CornDodgers.cs
 * Purpose: Handles the attributes of the Corn Dodgers Side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class represeting the Corn Dodgers side 
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// The price of the corn dodgers
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
        /// The calories of the corn dodgers 
        /// </summary>
        public override uint Calories
        {
            get
            {
                if(this.Size == Size.Small)
                {
                    return 512;
                }
                else if(this.Size == Size.Medium)
                {
                    return 685;
                }
                else
                {
                    return 717;
                }
            }
        }
    }
}
