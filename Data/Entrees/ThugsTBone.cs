using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: ThugsTBone.cs
 * Purpose: To represent the thugs t-bone menu option
 */
namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the steak
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        /// Gets the calories of the steak
        /// </summary>
        public override uint Calories => 982;

        /// <summary>
        /// Gets the description of the steak
        /// </summary>
        public string Description => "Juicy T-Bone, not much else to say.";

        /// <summary>
        /// Gets the list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
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
            return "Thugs T-Bone";
        }
    }
}
