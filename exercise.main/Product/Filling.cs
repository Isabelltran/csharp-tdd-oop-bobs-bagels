using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Product
{
    public class Filling : IProduct
    {
        private double _price = 0.12;
        public string Name { get; set; }
        public string ID { get; set; }
        public double Price { get { return _price; } set { _price = value; } } 
    }
}
