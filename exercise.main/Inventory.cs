using exercise.main.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Inventory
    {
        // Bagel
        public Bagel getOnionBagel()
        {
            return new Bagel() { Name = "Onion", BagelPrice = 0.49};
        }
        public Bagel getPlainBagel()
        {
            return new Bagel() { Name = "Plain", BagelPrice = 0.49 };
        }
        public Bagel getEverythingBagel()
        {
            return new Bagel() { Name = "Everything", BagelPrice = 0.49 };
        }
        public Bagel getSesameBagel()
        {
            return new Bagel() { Name = "Sesame", BagelPrice = 0.49 };
        }

        //Coffee
        public Coffee getBlackCoffee()
        {
            return new Coffee() { Name = "Black", Price = 0.99 };
        }
        public Coffee getWhiteCoffee()
        {
            return new Coffee() { Name = "White", Price = 1.19 };
        }
        public Coffee getCapuccinoCoffee()
        {
            return new Coffee() { Name = "Capuccino", Price = 1.19 };
        }
        public Coffee getLatteCoffee()
        {
            return new Coffee() { Name = "Latte", Price = 0.99 };
        }

        //Filling
        public Filling GetBaconFilling()
        {
            return new Filling() { Name = "Bacon", Price = 0.12 };
        }
        public Filling GetEggFilling()
        {
            return new Filling() { Name = "Egg", Price = 0.12 };
        }
        public Filling GetCheeseFilling()
        {
            return new Filling() { Name = "Cheese", Price = 0.12 };
        }
        public Filling GetCCFilling()
        {
            return new Filling() { Name = "Cream Cheese", Price = 0.12 };
        }
        public Filling GetSSFilling()
        {
            return new Filling() { Name = "Smoked Salmon", Price = 0.12 };
        }
        public Filling GetHamFilling()
        {
            return new Filling() { Name = "Ham", Price = 0.12 };
        }


    }
}
