using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Product
{
    public interface IProduct
    {
        string SKU { get; set; }
        string Name { get; set; }
        int ID { get; set; }
        double Price { get; set; }
    }
}
