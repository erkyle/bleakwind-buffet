using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: Entree.cs
 * Purpose: To represent an entree menu item
 */
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class represeting the common properties of an entree
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public abstract double Price {get;} 

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the entree 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
