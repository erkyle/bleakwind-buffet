using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: CandlehearthCoffee.cs
 * Purpose: To represent the candlehearth coffee menu option
 */
namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 0.75;
                else if (Size == Size.Medium)
                    return 1.25;
                else
                    return 1.75;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 7;
                else if (Size == Size.Medium)
                    return 10;
                else
                    return 20;
            }
        }

        /// <summary>
        /// Gets and sets the size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets and sets if the drink has ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Gets and sets if the drink has cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Gets and sets if the drink is decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Gets the list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the classes ToString output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Decaf == false)
                return String.Format("{0} Candlehearth Coffee", Size);
            else
               return String.Format("{0} Decaf Candlehearth Coffee", Size);
        }
    }
}