using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: DragonbornWaffleFries.cs
 * Purpose: To represent the dragonborn waffle fries menu option
 */
namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 0.42;
                else if (Size == Size.Medium)
                    return 0.76;
                else
                    return 0.96;
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
                    return 77;
                else if (Size == Size.Medium)
                    return 89;
                else
                    return 100;
            }
        }

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
            return String.Format("{0} Dragonborn Waffle Fries", Size);
        }
    }
}
