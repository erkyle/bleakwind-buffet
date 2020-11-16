using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: SmokehouseSkeleton.cs
 * Purpose: To represent the smokehouse skeleton menu option
 */
namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Gets the description of the combo
        /// </summary>
        public string Description => "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";

        /// <summary>
        /// Gets and sets if the combo includes sausage
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// Gets and sets if the combo includes eggs
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Gets and sets if the combo includes hash browns
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// Gets and sets if the combo includes pancakes
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// Gets the list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the classes ToString output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
