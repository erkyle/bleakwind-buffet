using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: FriedMiraak.cs
 * Purpose: To represent the fried miraak menu option
 */
namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side, IOrderItem
    {
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 1.78;
                else if (Size == Size.Medium)
                    return 2.01;
                else
                    return 2.88;
            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 151;
                else if (Size == Size.Medium)
                    return 236;
                else
                    return 306;
            }
        }

        /// <summary>
        /// Gets the description of the side
        /// </summary>
        public string Description => "Perfectly prepared hash brown pancakes.";

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
            return String.Format("{0} Fried Miraak", Size);
        }
    }
}