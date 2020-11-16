using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: ThalmorTriple.cs
 * Purpose: To represent the thalmor triple menu option
 */
namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 943;

        /// <summary>
        /// Gets the description of the burger
        /// </summary>
        public string Description => "Think you are strong enough to take on the Thalmor? Includes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";

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
        /// Gets and sets if the burger has bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Gets and sets if the burger has egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Gets the list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
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
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the classes ToString output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}

