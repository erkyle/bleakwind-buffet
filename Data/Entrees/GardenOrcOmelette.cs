using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: GardenOrcOmelette.cs
 * Purpose: To represent the garden orc omelette menu option
 */
namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Gets the price of the omelette
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// Gets the calories of the omelette
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// Gets and sets if the omelette includes broccoli
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Gets and sets if the omelette includes mushrooms
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Gets and sets if the omelette includes tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Gets and sets if the omelette includes cheddar
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// Gets the list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the classes ToString output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
