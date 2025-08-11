using exercise.main.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        private int _capacity = 5;
        private List<IProduct> _items = new List<IProduct>();

        public void Add(IProduct item)
        {
            if (_capacity > 0)
            {
                _items.Add(item);
                _capacity--;
            }
        }

        public bool Remove(string bagel)
        {
            foreach (Bagel b in _items)
            {
                if (b.Name == bagel)
                {
                    _items.Remove(b);
                    _capacity++;
                    return true;
                }
            }
             return false;
        }

        public bool IsFull()
        {
            return _capacity > 0;
        }
       
        public double TotalCost()
        {
            return _items.Sum(product => product.Price);
        }

        //public void Choosefillings(Bagel bagel, List<Filling> filling)
        //{
        //    bagel.AddFilling(filling);
        //}

        public List<IProduct> Items { get { return _items; } }

        public int Capacity { get { return _capacity; } set { _capacity = value; } }
    }
}
