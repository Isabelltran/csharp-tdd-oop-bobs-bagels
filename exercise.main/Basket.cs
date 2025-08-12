using exercise.main.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        private int _ID = 0;
        private int _capacity = 30;
        private List<IProduct> _items = new List<IProduct>();

        private List<Bagel> Amout_bagels()
        {
            List<Bagel> bagels = new List<Bagel>();
            foreach (IProduct item in _items)
            {
                if (item is Bagel bagel)
                {
                    bagels.Add(bagel);
                }
            }
            return bagels;
        }

        private List<Coffee> Amout_Coffee()
        {
            List<Coffee> coffee = new List<Coffee>();
            foreach (IProduct item in _items)
            {
                if (item is Coffee c)
                {
                    if (c.SKU == "COFB") 
                    {
                    coffee.Add(c);
                    }
                }
            }
            return coffee;
        }

        public bool Add(IProduct item)
        {
            if (_capacity > 0)
            {
                _items.Add(item);
                _capacity--;
                item.ID = _ID;
                _ID++;
                return true;
            }
            return false;
        }

        public void Remove(int id)
        {
            _items.RemoveAll(x => x.ID == id);
            _capacity++;
        }

        //public bool ValidSixBagels()
        //{
            
        //    if (_items.Where(p => p.SKU == "BGLO")) 
        //    {
        //        return true;
        //    }
        //    if (_items.Any(p => p.SKU == "BGLP"))
        //    { 
        //        return true;
        //    }
        //    return false;
        //}

        public double Discount()
        {
            // All bagels cost the same 
            double total = 0;
            double coffeeDiscount = 0;
            List<Bagel> bagels = Amout_bagels();
            List<Coffee> coffees = Amout_Coffee();

            Console.WriteLine("Amout of Bagel: " + bagels.Count);
            int BigPackBagels = 0;
            int SmallPackBagels = 0;

            int rest = 0;

            if (bagels.Count >= 6)
            {
                // For Big pack 12 for 3.99
                BigPackBagels += bagels.Count / 12;

                // For Small pack 6 for 2.49
                SmallPackBagels += (bagels.Count - (BigPackBagels * 12)) / 6;
                rest += (bagels.Count - (SmallPackBagels * 6)) % 6;

            }

            // Add coffee and Bagel Discount 
            int amout_coffeeDiscount = 0;
            int max = 0;
            int coffee = coffees.Count;
            if (coffee > rest) // Maybe get this on one-line 
            {
                max = coffee;
            }
            else
            {
                max = rest; 
            }

            for (int i = 0; i < max; i++)
            {
                if (coffee > 0 & rest > 0)
                {
                    coffee--;
                    rest--;
                    amout_coffeeDiscount++;
                }
            }

            total += amout_coffeeDiscount * 1.25 + coffeeDiscount + (rest * 0.49) + (coffee * 0.99) + (BigPackBagels * 3.99) + (SmallPackBagels * 2.49);
        
            return total;
        }

        public string printReceipt()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append($"~~~Bob's Bagels ~~~");
            sb.Append($"\n{DateTime.Now.ToString()}");

            sb.Append($"\n----------------------------");
            
            

            foreach (IProduct item in _items)
            {
                sb.Append($"\n{item.Name} - £{item.Price}");
            }
            sb.Append($"\n----------------------------");
            sb.Append($"\nTotal : {this.TotalCost()}");
            sb.Append($"\nThank you for your order!");
         
            return sb.ToString();
        }

//        ~~~Bob's Bagels ~~~

//    2021-03-16 21:38:44

//----------------------------

//Onion Bagel        2   £0.98
//Plain Bagel        12  £3.99
//Everything Bagel   6   £2.49
//Coffee             3   £2.97

//----------------------------
//Total                 £10.43

//        Thank you
//      for your order!

        public bool IsFull() { return _capacity <= 0; }
       
        public double TotalCost() { return _items.Sum(product => product.Price); }

        public List<IProduct> Items { get { return _items; } }

        public int Capacity { get { return _capacity; } set { _capacity = value; } }
    }
}
