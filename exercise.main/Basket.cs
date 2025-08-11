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

        public void Add(Bagel bagel)
        {
            if (_capacity > 0)
            {
                _items.Add(bagel);
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

        public bool RemoveExist(string bagel)
        {
            foreach(Bagel b in _items)
            {
                if (b.Name == bagel)
                {
                    _items.Remove(b);
                    return true; ;
                }
            }
            return false;
        }

        public List<IProduct> Items { get { return _items; } }

        public int Capacity { get { return _capacity; } set { _capacity = value; } }
    }
}
