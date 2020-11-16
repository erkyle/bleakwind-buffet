using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: SailorSoda.cs
 * Purpose: To represent the sailor soda menu option
 */
namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// An event fired when a property of this object changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 1.42;
                else if (Size == Size.Medium)
                    return 1.74;
                else
                    return 2.07;
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
                    return 117;
                else if (Size == Size.Medium)
                    return 153;
                else
                    return 205;
            }
        }

        /// <summary>
        /// Gets the description of the drink
        /// </summary>
        public string Description => "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";

        private bool ice = true;
        /// <summary>
        /// Gets and sets if the drink has ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set
            {
                if (ice != value)
                {
                    ice = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                }
            }
        }

        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// Gets and sets the flavor of the drink
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set
            {
                if (flavor != value)
                {
                    flavor = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                }
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
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the classes ToString output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0} {1} Sailor Soda", Size, Flavor);
        }
    }
}
