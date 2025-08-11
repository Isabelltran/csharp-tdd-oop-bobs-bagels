using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Product
{
    public class Filling : IProduct
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public double Price { get; set; }
    }
}
