using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Biblioteka.Model
{
    public class LibraryObject
    {
        public decimal Price { get; set; }
        public string Description { get; set; }

        public LibraryObject(decimal price, string desc)
        {
            Price = price;
            Description = desc;
        }
    }
}
