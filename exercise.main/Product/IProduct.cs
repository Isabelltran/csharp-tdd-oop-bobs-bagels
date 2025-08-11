using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Product
{
    public interface IProduct
    {
        string Name { get; set; }
        string ID { get; set; }
        double Price { get; set; }
    }
}
