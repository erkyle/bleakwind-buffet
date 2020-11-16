using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: CandlehearthCoffee.cs
 * Purpose: To represent the candlehearth coffee menu option
 */
namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
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
                    return 0.75;
                else if (Size == Size.Medium)
                    return 1.25;
                else
                    return 1.75;
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
                    return 7;
                else if (Size == Size.Medium)
                    return 10;
                else
                    return 20;
            }
        }

        /// <summary>
        /// Gets the description of the drink
        /// </summary>
        public string Description => "Fair trade, fresh ground dark roast coffee.";

        private bool ice = false;
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

        private bool roomForCream = false;
        /// <summary>
        /// Gets and sets if the drink has cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                if (roomForCream != value)
                {
                    roomForCream = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                }
            }
        }

        private bool decaf = false;
        /// <summary>
        /// Gets and sets if the drink is decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                if (decaf != value)
                {
                    decaf = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
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
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the classes ToString output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Decaf == false)
                return String.Format("{0} Candlehearth Coffee", Size);
            else
               return String.Format("{0} Decaf Candlehearth Coffee", Size);
        }
    }
}