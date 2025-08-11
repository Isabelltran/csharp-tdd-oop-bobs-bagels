using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Product
{
    public class Bagel : IProduct
    {

        private double _price;
        private List<Filling> _filling = new List<Filling>();

        public void AddFilling(Filling filling)
        {
            _filling.Add(filling);
        }


        public void SeeFillingCost()
        {
            foreach (Filling filling in _filling)
            {
                Console.WriteLine($"Filling, {filling.Name}: {filling.Price}");
            }

        }

        public string Name { get; set; }
        public string ID { get; set; }

        public double BagelPrice { get { return _price; } set { _price = value; } }

        public double Price { get { return _price + _filling.Sum(filling => filling.Price); } set; }

        public List<Filling> Filling { get { return _filling; } }
    }
}
