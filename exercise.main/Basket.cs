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
        private int _capacity = 10;
        private List<IProduct> _items = new List<IProduct>();

        public void Add(Bagel bagel)
        {
            if (_capacity > 0)
            {
                _items.Add(bagel);
                _capacity--;
            }
        }

        public List<IProduct> Items { get { return _items; } }

        public int Capacity { get { return _capacity; } }
    }
}
