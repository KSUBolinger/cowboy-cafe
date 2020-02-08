using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class represetning an entree 
    /// </summary>
    public abstract class Entree
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
    }
}
