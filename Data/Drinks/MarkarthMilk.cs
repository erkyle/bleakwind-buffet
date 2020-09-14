using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: MarkarthMilk.cs
 * Purpose: To represent the markarth milk menu option
 */
namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink, IOrderItem
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 1.05;
                else if (Size == Size.Medium)
                    return 1.11;
                else
                    return 1.22;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 56;
                else if (Size == Size.Medium)
                    return 72;
                else
                    return 93;
            }
        }

        /// <summary>
        /// Gets and sets if the drink has ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Gets the list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the classes ToString output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0} Markarth Milk", Size);
        }
    }
}
