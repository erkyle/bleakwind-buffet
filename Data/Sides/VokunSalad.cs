using BleakwindBuffet.Data.Enums;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: VokunSalad.cs
 * Purpose: To represent the vokun salad menu option
 */
namespace Data.Sides
{
    public class VokunSalad
    {
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 0.93;
                else if (Size == Size.Medium)
                    return 1.28;
                else
                    return 1.82;
            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 41;
                else if (Size == Size.Medium)
                    return 52;
                else
                    return 73;
            }
        }

        /// <summary>
        /// Gets and sets the size of the side
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the classes ToString output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0} Vokun Salad", Size);
        }
    }
}
