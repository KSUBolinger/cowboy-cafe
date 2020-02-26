using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// an interface representing a single item in an order
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// the price of this order
        /// </summary>
        double Price { get; }
        /// <summary>
        /// the special instructions for this order
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
