using exercise.main;
using exercise.main.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace exercise.tests
{
    public class ExtensionTests
    {
        Basket _basket = new Basket();

        private void AddSixBagels()
        {
            Inventory inventory = new Inventory();
            Bagel bagel = inventory.getPlainBagel();
            Bagel bagel1 = inventory.getPlainBagel();
            Bagel bagel2 = inventory.getPlainBagel();
            Bagel bagel3 = inventory.getPlainBagel();
            Bagel bagel4 = inventory.getPlainBagel();
            Bagel bagel5 = inventory.getPlainBagel();

            _basket.Add(bagel);
            _basket.Add(bagel1);
            _basket.Add(bagel2);
            _basket.Add(bagel3);
            _basket.Add(bagel4);
            _basket.Add(bagel5);
        }

        private void AddTwelveBagels()
        {
            Inventory inventory = new Inventory();
            Bagel bagel = inventory.getPlainBagel();
            Bagel bagel1 = inventory.getPlainBagel();
            Bagel bagel2 = inventory.getPlainBagel();
            Bagel bagel3 = inventory.getPlainBagel();
            Bagel bagel4 = inventory.getPlainBagel();
            Bagel bagel5 = inventory.getPlainBagel();
            Bagel bagel6 = inventory.getPlainBagel();
            Bagel bagel7 = inventory.getPlainBagel();
            Bagel bagel8 = inventory.getPlainBagel();
            Bagel bagel9 = inventory.getPlainBagel();
            Bagel bagel10 = inventory.getPlainBagel();
            Bagel bagel11 = inventory.getPlainBagel();

            _basket.Add(bagel);
            _basket.Add(bagel1);
            _basket.Add(bagel2);
            _basket.Add(bagel3);
            _basket.Add(bagel4);
            _basket.Add(bagel5);
            _basket.Add(bagel6);
            _basket.Add(bagel7);
            _basket.Add(bagel8);
            _basket.Add(bagel9);
            _basket.Add(bagel10);
            _basket.Add(bagel11);
        }

        [Test]
        public void DiscountTest()
        {
            AddSixBagels();

            Console.WriteLine("Basket Capacity: " + _basket.Capacity);
            Console.WriteLine("Basket Discount: " + _basket.Discount());

            double result = _basket.Discount();


            Assert.That(result, Is.EqualTo(2.49));
        }

        [Test]
        public void DiscountTestExampleOne()
        {
            AddSixBagels();
            AddTwelveBagels();

            // Adding 3 coffee and 2 Onion
            Inventory inventory = new Inventory();
            Bagel bagel = inventory.getOnionBagel();
            Bagel bagel1 = inventory.getOnionBagel();
            Coffee c = inventory.getBlackCoffee();
            Coffee c1 = inventory.getBlackCoffee();
            Coffee c2 = inventory.getBlackCoffee();

            _basket.Add(bagel);
            _basket.Add(bagel1);
            _basket.Add(c);
            _basket.Add(c1);
            _basket.Add(c2);

            Console.WriteLine("Basket Capacity: " + _basket.Capacity);
            Console.WriteLine("Basket Discount: " + _basket.Discount());

            double result = _basket.Discount();


            Assert.That(result, Is.EqualTo(9.97));

            //            2x BGLO = 0.98
            //            12x BGLP = 3.99
            //            6x BGLE = 2.49
            //            3x COF = 2.97
            //              ----
            //              9.97
        }

        [Test]
        public void DiscountTestExampleTwo()
        {
            AddTwelveBagels();

            // Adding 3 coffee and 2 Onion
            Inventory inventory = new Inventory();
            Bagel bagel = inventory.getPlainBagel();
            Bagel bagel1 = inventory.getPlainBagel();
            Bagel bagel2 = inventory.getPlainBagel();
            Bagel bagel3 = inventory.getPlainBagel();


            _basket.Add(bagel);
            _basket.Add(bagel1);
            _basket.Add(bagel2);
            _basket.Add(bagel3);


            Console.WriteLine("Basket Capacity: " + _basket.Capacity);
            Console.WriteLine("Basket Discount: " + _basket.Discount());

            double result = _basket.Discount();


            Assert.That(result, Is.EqualTo(5.95));
        }

        //16x BGLP = 5.55
        //   ----
        //   5.55
    }
}
