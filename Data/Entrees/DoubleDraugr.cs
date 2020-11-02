using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: DoubleDraugr.cs
 * Purpose: To represent the double draugr menu option
 */
namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// An event fired when a property of this object changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 7.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 843;

        private bool bun = true;
        /// <summary>
        /// Gets and sets if the burger has a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                if (bun != value)
                {
                    bun = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                }
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// Gets and sets if the burger has ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                if (ketchup != value)
                {
                    ketchup = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                }
            }
        }

        private bool mustard = true;
        /// <summary>
        /// Gets and sets if the burger has mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                if (mustard != value)
                {
                    mustard = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                }
            }
        }

        private bool pickle = true;
        /// <summary>
        /// Gets and sets if the burger has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                if (pickle != value)
                {
                    pickle = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                }
            }
        }

        private bool cheese = true;
        /// <summary>
        /// Gets and sets if the burger has cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                if (cheese != value)
                {
                    cheese = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                }
            }
        }

        private bool tomato = true;
        /// <summary>
        /// Gets and sets if the burger has tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                if (tomato != value)
                {
                    tomato = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                }
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// Gets and sets if the burger has lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                if (lettuce != value)
                {
                    lettuce = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                }
            }
        }

        private bool mayo = true;
        /// <summary>
        /// Gets and sets if the burger has mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                if (mayo != value)
                {
                    mayo = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
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
