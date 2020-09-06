using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: DoubleDraugr.cs
 * Purpose: To represent the double draugr menu option
 */
namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 7.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories => 843;

        /// <summary>
        /// Gets and sets if the burger has a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Gets and sets if the burger has ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Gets and sets if the burger has mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Gets and sets if the burger has pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Gets and sets if the burger has cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Gets and sets if the burger has tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Gets and sets if the burger has lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Gets and sets if the burger has mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Gets the list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the classes ToString output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
