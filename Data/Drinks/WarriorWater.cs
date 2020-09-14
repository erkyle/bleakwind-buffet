using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: WarriorWater.cs
 * Purpose: To represent the warrior water menu option
 */
namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink, IOrderItem
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public override double Price => 0.00;

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public override uint Calories => 0;

        /// <summary>
        /// Gets and sets if the drink has ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets and sets if the drink has lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Gets the list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the classes ToString output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0} Warrior Water", Size);
        }
    }
}
