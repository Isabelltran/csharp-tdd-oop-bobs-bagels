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
        private List<Fillings> _fillings = new List<Fillings> ();

        public void AddFilling(Fillings filling)
        {
            _fillings.Add(filling);
        }

        
        public string Name { get; set; }
        public string ID { get; set; }
        public double Price { get; set; }

        public List<Fillings> Fillings { get { return _fillings; } }
    }
}
