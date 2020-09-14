﻿using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: AretinoAppleJuice.cs
 * Purpose: To represent the aretino apple juice menu option
 */
namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink, IOrderItem
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 0.62;
                else if (Size == Size.Medium)
                    return 0.87;
                else
                    return 1.01;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 44;
                else if (Size == Size.Medium)
                    return 88;
                else
                    return 132;
            }
        }

        /// <summary>
        /// Gets and sets if the drink has ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Gets the list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the classes ToString output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0} Aretino Apple Juice", Size);
        }
    }
}
