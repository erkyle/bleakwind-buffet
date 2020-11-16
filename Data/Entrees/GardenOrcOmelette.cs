using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Eric Kyle
 * Class name: GardenOrcOmelette.cs
 * Purpose: To represent the garden orc omelette menu option
 */
namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// An event fired when a property of this object changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the omelette
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Gets the calories of the omelette
        /// </summary>
        public override uint Calories => 404;

        /// <summary>
        /// Gets the description of the omelette
        /// </summary>
        public string Description => "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";

        private bool broccoli = true;
        /// <summary>
        /// Gets and sets if the omelette includes broccoli
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; }
            set
            {
                if (broccoli != value)
                {
                    broccoli = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                }
            }
        }

        private bool mushrooms = true;
        /// <summary>
        /// Gets and sets if the omelette includes mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set
            {
                if (mushrooms != value)
                {
                    mushrooms = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                }
            }
        }

        private bool tomato = true;
        /// <summary>
        /// Gets and sets if the omelette includes tomato
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

        private bool cheddar = true;
        /// <summary>
        /// Gets and sets if the omelette includes cheddar
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set
            {
                if (cheddar != value)
                {
                    cheddar = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
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
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the classes ToString output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
