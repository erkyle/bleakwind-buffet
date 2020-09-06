using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: MadOtarGrits.cs
 * Purpose: To represent the mad otar grits menu option
 */
namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 1.22;
                else if (Size == Size.Medium)
                    return 1.58;
                else
                    return 1.93;
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
                    return 105;
                else if (Size == Size.Medium)
                    return 142;
                else
                    return 179;
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
            return String.Format("{0} Mad Otar Grits", Size);
        }
    }
}