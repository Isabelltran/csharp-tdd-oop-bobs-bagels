using exercise.main.Product;
using System;
using System.Collections.Generic;
using System.IO;
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
            return new Bagel() { SKU = "BGLO", Name = "Onion", BagelPrice = 0.49};
        }
        public Bagel getPlainBagel()
        {
            return new Bagel() { SKU = "BGLP", Name = "Plain", BagelPrice = 0.39 };
        }
        public Bagel getEverythingBagel()
        {
            return new Bagel() { SKU = "BGLE", Name = "Everything", BagelPrice = 0.49 };
        }
        public Bagel getSesameBagel()
        {
            return new Bagel() { SKU = "BGLS", Name = "Sesame", BagelPrice = 0.49 };
        }

        //Coffee
        public Coffee getBlackCoffee()
        {
            return new Coffee() { SKU = "COFB", Name = "Black", Price = 0.99 };
        }
        public Coffee getWhiteCoffee()
        {
            return new Coffee() { SKU = "COFW", Name = "White", Price = 1.19 };
        }
        public Coffee getCapuccinoCoffee()
        {
            return new Coffee() { SKU = "COFC", Name = "Capuccino", Price = 1.19 };
        }
        public Coffee getLatteCoffee()
        {
            return new Coffee() { SKU = "COFL", Name = "Latte", Price = 0.99 };
        }

        //Filling
        public Filling GetBaconFilling()
        {
            return new Filling() { SKU = "FILB", Name = "Bacon", Price = 0.12 };
        }
        public Filling GetEggFilling()
        {
            return new Filling() { SKU = "FILE", Name = "Egg", Price = 0.12 };
        }
        public Filling GetCheeseFilling()
        {
            return new Filling() { SKU = "FILC", Name = "Cheese", Price = 0.12 };
        }
        public Filling GetCCFilling()
        {
            return new Filling() { SKU = "FILX", Name = "Cream Cheese", Price = 0.12 };
        }
        public Filling GetSSFilling()
        {
            return new Filling() { SKU = "FILS", Name = "Smoked Salmon", Price = 0.12 };
        }
        public Filling GetHamFilling()
        {
            return new Filling() { SKU = "FILH", Name = "Ham", Price = 0.12 };
        }


    }
}
