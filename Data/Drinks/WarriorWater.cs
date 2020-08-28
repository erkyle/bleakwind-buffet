using BleakwindBuffet.Data.Enums;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: WarriorWater.cs
 * Purpose: To represent the warrior water menu option
 */
namespace Data.Drinks
{
    public class WarriorWater
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public double Price => 0.00;

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public uint Calories => 0;

        /// <summary>
        /// Gets and sets the size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

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
        public List<string> SpecialInstructions
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
