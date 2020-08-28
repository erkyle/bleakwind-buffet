using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: PhillyPoacher.cs
 * Purpose: To represent the philly poacher menu option
 */
namespace Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// Gets the price of the sandwich
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// Gets the calories of the sandwich
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// Gets and sets if the sandwich includes sirloin
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// Gets and sets if the sandwich includes onions
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Gets and sets if the sandwich includes roll
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// Gets the list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the classes ToString output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
