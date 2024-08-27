using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product_Subcategory
    {
        public int Id_Product { get; set; }
        public Product Product { get; set; }
        public int Id_Subcategory { get; set; }
        public Subcategory Subcategory { get; set; }
    }
}
