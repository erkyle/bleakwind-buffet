﻿using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: VokunSalad.cs
 * Purpose: To represent the vokun salad menu option
 */
namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad : Side, IOrderItem
    {
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public override double Price
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
        public override uint Calories
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
        /// Gets the description of the side
        /// </summary>
        public string Description => "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";

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
            return String.Format("{0} Vokun Salad", Size);
        }
    }
}
