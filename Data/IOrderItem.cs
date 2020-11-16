using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: IOrderItem.cs
 * Purpose: To represent a menu item
 */
namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface for menu item properties
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The calories of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the item
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// The description of the item
        /// </summary>
        string Description { get; }
    }
}
