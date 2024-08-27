using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product_Category
    {
        public int Id_Category { get; set; }
        public Category Category { get; set; }
        public int Id_Product { get; set; }
        public Product Product { get; set; }
    }
}
