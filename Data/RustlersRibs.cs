/*
 * Author: Easton Bolinger
 * Class: RustlersRibs.cs
 * Purpose: Handles the attributes of the Rustlers Ribs Entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price for the ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories for the ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for preparing the ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representing the ribs
        /// </summary>
        /// <returns>string decribing the ribs</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
