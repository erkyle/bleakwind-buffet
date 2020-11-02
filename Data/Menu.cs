using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.ExceptionServices;
using System.Linq;
using System.Data.Common;
using System.Runtime.CompilerServices;

/*
 * Author: Eric Kyle
 * Class name: Menu.cs
 * Purpose: To represent the menu
 */
namespace Data
{
    /// <summary>
    /// A class represeting the menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Makes a collection of all entree items
        /// </summary>
        /// <returns>A list of all entree items</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            return entrees;
        }

        /// <summary>
        /// Makes a collection of all side items
        /// </summary>
        /// <returns>A list of all side items</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            DragonbornWaffleFries wfSmall = new DragonbornWaffleFries();
            DragonbornWaffleFries wfMed = new DragonbornWaffleFries();
            DragonbornWaffleFries wfLarge = new DragonbornWaffleFries();
            FriedMiraak fmSmall = new FriedMiraak();
            FriedMiraak fmMed = new FriedMiraak();
            FriedMiraak fmLarge = new FriedMiraak();
            MadOtarGrits mgSmall = new MadOtarGrits();
            MadOtarGrits mgMed = new MadOtarGrits();
            MadOtarGrits mgLarge = new MadOtarGrits();
            VokunSalad vsSmall = new VokunSalad();
            VokunSalad vsMed = new VokunSalad();
            VokunSalad vsLarge = new VokunSalad();
            wfSmall.Size = Size.Small;
            wfMed.Size = Size.Medium;
            wfLarge.Size = Size.Large;
            fmSmall.Size = Size.Small;
            fmMed.Size = Size.Medium;
            fmLarge.Size = Size.Large;
            mgSmall.Size = Size.Small;
            mgMed.Size = Size.Medium;
            mgLarge.Size = Size.Large;
            vsSmall.Size = Size.Small;
            vsMed.Size = Size.Medium;
            vsLarge.Size = Size.Large;
            sides.Add(wfSmall);
            sides.Add(wfMed);
            sides.Add(wfLarge);
            sides.Add(fmSmall);
            sides.Add(fmMed);
            sides.Add(fmLarge);
            sides.Add(mgSmall);
            sides.Add(mgMed);
            sides.Add(mgLarge);
            sides.Add(vsSmall);
            sides.Add(vsMed);
            sides.Add(vsLarge);
            return sides;
        }

        /// <summary>
        /// Makes a collection of all drinks
        /// </summary>
        /// <returns>A list of all drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            AretinoAppleJuice ajSmall = new AretinoAppleJuice();
            AretinoAppleJuice ajMed = new AretinoAppleJuice();
            AretinoAppleJuice ajLarge = new AretinoAppleJuice();
            CandlehearthCoffee ccSmall = new CandlehearthCoffee();
            CandlehearthCoffee ccMed = new CandlehearthCoffee();
            CandlehearthCoffee ccLarge = new CandlehearthCoffee();
            MarkarthMilk mmSmall = new MarkarthMilk();
            MarkarthMilk mmMed = new MarkarthMilk();
            MarkarthMilk mmLarge = new MarkarthMilk();
            WarriorWater wwSmall = new WarriorWater();
            WarriorWater wwMed = new WarriorWater();
            WarriorWater wwLarge = new WarriorWater();
            SailorSoda blackberrySmall = new SailorSoda();
            SailorSoda blackberryMed = new SailorSoda();
            SailorSoda blackberryLarge = new SailorSoda();
            SailorSoda cherrySmall = new SailorSoda();
            SailorSoda cherryMed = new SailorSoda();
            SailorSoda cherryLarge = new SailorSoda();
            SailorSoda grapefruitSmall = new SailorSoda();
            SailorSoda grapefruitMed = new SailorSoda();
            SailorSoda grapefruitLarge = new SailorSoda();
            SailorSoda lemonSmall = new SailorSoda();
            SailorSoda lemonMed = new SailorSoda();
            SailorSoda lemonLarge = new SailorSoda();
            SailorSoda peachSmall = new SailorSoda();
            SailorSoda peachMed = new SailorSoda();
            SailorSoda peachLarge = new SailorSoda();
            SailorSoda watermelonSmall = new SailorSoda();
            SailorSoda watermelonMed = new SailorSoda();
            SailorSoda watermelonLarge = new SailorSoda();
            ajSmall.Size = Size.Small;
            ajMed.Size = Size.Medium;
            ajLarge.Size = Size.Large;
            ccSmall.Size = Size.Small;
            ccMed.Size = Size.Medium;
            ccLarge.Size = Size.Large;
            mmSmall.Size = Size.Small;
            mmMed.Size = Size.Medium;
            mmLarge.Size = Size.Large;
            wwSmall.Size = Size.Small;
            wwMed.Size = Size.Medium;
            wwLarge.Size = Size.Large;
            blackberrySmall.Size = Size.Small;
            blackberrySmall.Flavor = SodaFlavor.Blackberry;
            blackberryMed.Size = Size.Medium;
            blackberryMed.Flavor = SodaFlavor.Blackberry;
            blackberryLarge.Size = Size.Large;
            blackberryLarge.Flavor = SodaFlavor.Blackberry;
            cherrySmall.Size = Size.Small;
            cherrySmall.Flavor = SodaFlavor.Cherry;
            cherryMed.Size = Size.Medium;
            cherryMed.Flavor = SodaFlavor.Cherry;
            cherryLarge.Size = Size.Large;
            cherryLarge.Flavor = SodaFlavor.Cherry;
            grapefruitSmall.Size = Size.Small;
            grapefruitSmall.Flavor = SodaFlavor.Grapefruit;
            grapefruitMed.Size = Size.Medium;
            grapefruitMed.Flavor = SodaFlavor.Grapefruit;
            grapefruitLarge.Size = Size.Large;
            grapefruitLarge.Flavor = SodaFlavor.Grapefruit;
            lemonSmall.Size = Size.Small;
            lemonSmall.Flavor = SodaFlavor.Lemon;
            lemonMed.Size = Size.Medium;
            lemonMed.Flavor = SodaFlavor.Lemon;
            lemonLarge.Size = Size.Large;
            lemonLarge.Flavor = SodaFlavor.Lemon;
            peachSmall.Size = Size.Small;
            peachSmall.Flavor = SodaFlavor.Peach;
            peachMed.Size = Size.Medium;
            peachMed.Flavor = SodaFlavor.Peach;
            peachLarge.Size = Size.Large;
            peachLarge.Flavor = SodaFlavor.Peach;
            watermelonSmall.Size = Size.Small;
            watermelonSmall.Flavor = SodaFlavor.Watermelon;
            watermelonMed.Size = Size.Medium;
            watermelonMed.Flavor = SodaFlavor.Watermelon;
            watermelonLarge.Size = Size.Large;
            watermelonLarge.Flavor = SodaFlavor.Watermelon;
            drinks.Add(ajSmall);
            drinks.Add(ajMed);
            drinks.Add(ajLarge);
            drinks.Add(ccSmall);
            drinks.Add(ccMed);
            drinks.Add(ccLarge);
            drinks.Add(mmSmall);
            drinks.Add(mmMed);
            drinks.Add(mmLarge);
            drinks.Add(wwSmall);
            drinks.Add(wwMed);
            drinks.Add(wwLarge);
            drinks.Add(blackberrySmall);
            drinks.Add(blackberryMed);
            drinks.Add(blackberryLarge);
            drinks.Add(cherrySmall);
            drinks.Add(cherryMed);
            drinks.Add(cherryLarge);
            drinks.Add(grapefruitSmall);
            drinks.Add(grapefruitMed);
            drinks.Add(grapefruitLarge);
            drinks.Add(lemonSmall);
            drinks.Add(lemonMed);
            drinks.Add(lemonLarge);
            drinks.Add(peachSmall);
            drinks.Add(peachMed);
            drinks.Add(peachLarge);
            drinks.Add(watermelonSmall);
            drinks.Add(watermelonMed);
            drinks.Add(watermelonLarge);
            return drinks;
        }

        /// <summary>
        /// Makes a collection of all items on the menu
        /// </summary>
        /// <returns>A list of all items on the menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            menu.Add(new BriarheartBurger());
            menu.Add(new DoubleDraugr());
            menu.Add(new GardenOrcOmelette());
            menu.Add(new PhillyPoacher());
            menu.Add(new SmokehouseSkeleton());
            menu.Add(new ThalmorTriple());
            menu.Add(new ThugsTBone());
            DragonbornWaffleFries wfSmall = new DragonbornWaffleFries();
            DragonbornWaffleFries wfMed = new DragonbornWaffleFries();
            DragonbornWaffleFries wfLarge = new DragonbornWaffleFries();
            FriedMiraak fmSmall = new FriedMiraak();
            FriedMiraak fmMed = new FriedMiraak();
            FriedMiraak fmLarge = new FriedMiraak();
            MadOtarGrits mgSmall = new MadOtarGrits();
            MadOtarGrits mgMed = new MadOtarGrits();
            MadOtarGrits mgLarge = new MadOtarGrits();
            VokunSalad vsSmall = new VokunSalad();
            VokunSalad vsMed = new VokunSalad();
            VokunSalad vsLarge = new VokunSalad();
            wfSmall.Size = Size.Small;
            wfMed.Size = Size.Medium;
            wfLarge.Size = Size.Large;
            fmSmall.Size = Size.Small;
            fmMed.Size = Size.Medium;
            fmLarge.Size = Size.Large;
            mgSmall.Size = Size.Small;
            mgMed.Size = Size.Medium;
            mgLarge.Size = Size.Large;
            vsSmall.Size = Size.Small;
            vsMed.Size = Size.Medium;
            vsLarge.Size = Size.Large;
            menu.Add(wfSmall);
            menu.Add(wfMed);
            menu.Add(wfLarge);
            menu.Add(fmSmall);
            menu.Add(fmMed);
            menu.Add(fmLarge);
            menu.Add(mgSmall);
            menu.Add(mgMed);
            menu.Add(mgLarge);
            menu.Add(vsSmall);
            menu.Add(vsMed);
            menu.Add(vsLarge);
            AretinoAppleJuice ajSmall = new AretinoAppleJuice();
            AretinoAppleJuice ajMed = new AretinoAppleJuice();
            AretinoAppleJuice ajLarge = new AretinoAppleJuice();
            CandlehearthCoffee ccSmall = new CandlehearthCoffee();
            CandlehearthCoffee ccMed = new CandlehearthCoffee();
            CandlehearthCoffee ccLarge = new CandlehearthCoffee();
            MarkarthMilk mmSmall = new MarkarthMilk();
            MarkarthMilk mmMed = new MarkarthMilk();
            MarkarthMilk mmLarge = new MarkarthMilk();
            WarriorWater wwSmall = new WarriorWater();
            WarriorWater wwMed = new WarriorWater();
            WarriorWater wwLarge = new WarriorWater();
            SailorSoda blackberrySmall = new SailorSoda();
            SailorSoda blackberryMed = new SailorSoda();
            SailorSoda blackberryLarge = new SailorSoda();
            SailorSoda cherrySmall = new SailorSoda();
            SailorSoda cherryMed = new SailorSoda();
            SailorSoda cherryLarge = new SailorSoda();
            SailorSoda grapefruitSmall = new SailorSoda();
            SailorSoda grapefruitMed = new SailorSoda();
            SailorSoda grapefruitLarge = new SailorSoda();
            SailorSoda lemonSmall = new SailorSoda();
            SailorSoda lemonMed = new SailorSoda();
            SailorSoda lemonLarge = new SailorSoda();
            SailorSoda peachSmall = new SailorSoda();
            SailorSoda peachMed = new SailorSoda();
            SailorSoda peachLarge = new SailorSoda();
            SailorSoda watermelonSmall = new SailorSoda();
            SailorSoda watermelonMed = new SailorSoda();
            SailorSoda watermelonLarge = new SailorSoda();
            ajSmall.Size = Size.Small;
            ajMed.Size = Size.Medium;
            ajLarge.Size = Size.Large;
            ccSmall.Size = Size.Small;
            ccMed.Size = Size.Medium;
            ccLarge.Size = Size.Large;
            mmSmall.Size = Size.Small;
            mmMed.Size = Size.Medium;
            mmLarge.Size = Size.Large;
            wwSmall.Size = Size.Small;
            wwMed.Size = Size.Medium;
            wwLarge.Size = Size.Large;
            blackberrySmall.Size = Size.Small;
            blackberrySmall.Flavor = SodaFlavor.Blackberry;
            blackberryMed.Size = Size.Medium;
            blackberryMed.Flavor = SodaFlavor.Blackberry;
            blackberryLarge.Size = Size.Large;
            blackberryLarge.Flavor = SodaFlavor.Blackberry;
            cherrySmall.Size = Size.Small;
            cherrySmall.Flavor = SodaFlavor.Cherry;
            cherryMed.Size = Size.Medium;
            cherryMed.Flavor = SodaFlavor.Cherry;
            cherryLarge.Size = Size.Large;
            cherryLarge.Flavor = SodaFlavor.Cherry;
            grapefruitSmall.Size = Size.Small;
            grapefruitSmall.Flavor = SodaFlavor.Grapefruit;
            grapefruitMed.Size = Size.Medium;
            grapefruitMed.Flavor = SodaFlavor.Grapefruit;
            grapefruitLarge.Size = Size.Large;
            grapefruitLarge.Flavor = SodaFlavor.Grapefruit;
            lemonSmall.Size = Size.Small;
            lemonSmall.Flavor = SodaFlavor.Lemon;
            lemonMed.Size = Size.Medium;
            lemonMed.Flavor = SodaFlavor.Lemon;
            lemonLarge.Size = Size.Large;
            lemonLarge.Flavor = SodaFlavor.Lemon;
            peachSmall.Size = Size.Small;
            peachSmall.Flavor = SodaFlavor.Peach;
            peachMed.Size = Size.Medium;
            peachMed.Flavor = SodaFlavor.Peach;
            peachLarge.Size = Size.Large;
            peachLarge.Flavor = SodaFlavor.Peach;
            watermelonSmall.Size = Size.Small;
            watermelonSmall.Flavor = SodaFlavor.Watermelon;
            watermelonMed.Size = Size.Medium;
            watermelonMed.Flavor = SodaFlavor.Watermelon;
            watermelonLarge.Size = Size.Large;
            watermelonLarge.Flavor = SodaFlavor.Watermelon;
            menu.Add(ajSmall);
            menu.Add(ajMed);
            menu.Add(ajLarge);
            menu.Add(ccSmall);
            menu.Add(ccMed);
            menu.Add(ccLarge);
            menu.Add(mmSmall);
            menu.Add(mmMed);
            menu.Add(mmLarge);
            menu.Add(wwSmall);
            menu.Add(wwMed);
            menu.Add(wwLarge);
            menu.Add(blackberrySmall);
            menu.Add(blackberryMed);
            menu.Add(blackberryLarge);
            menu.Add(cherrySmall);
            menu.Add(cherryMed);
            menu.Add(cherryLarge);
            menu.Add(grapefruitSmall);
            menu.Add(grapefruitMed);
            menu.Add(grapefruitLarge);
            menu.Add(lemonSmall);
            menu.Add(lemonMed);
            menu.Add(lemonLarge);
            menu.Add(peachSmall);
            menu.Add(peachMed);
            menu.Add(peachLarge);
            menu.Add(watermelonSmall);
            menu.Add(watermelonMed);
            menu.Add(watermelonLarge);
            return menu;
        }
    }
}
