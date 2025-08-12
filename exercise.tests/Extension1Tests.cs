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
    public class Extension1Tests
    {
        Basket _basket = new Basket();

        private void AddSixBagels()
        {
            Inventory inventory = new Inventory();
            Bagel bagel = inventory.getPlainBagel();
            for (int i=0; i<6; i++)
            {
                _basket.Add(bagel);
            }
        }

        private void AddTwelveBagels()
        {
            Inventory inventory = new Inventory();
            Bagel bagel = inventory.getPlainBagel();
            for (int i = 0; i < 12; i++)
            {
                _basket.Add(bagel);
            }
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
            AddTwelveBagels(); // Onion ...

            // Adding 3 coffee and 2 Onion
            Inventory inventory = new Inventory();
            Bagel bagel = inventory.getPlainBagel();
            for (int i = 0; i < 4; i++)
            {
                _basket.Add(bagel);
            }


            Console.WriteLine("Basket Capacity: " + _basket.Capacity);
            Console.WriteLine("Basket Discount: " + _basket.Discount());

            double result = _basket.Discount();


            Assert.That(result, Is.EqualTo(5.95));
        }

        //16x BGLP = 5.95 -- Plain cost 0.49 instead for 0.39
        //   ----
        //   5.95

       
    }
}
