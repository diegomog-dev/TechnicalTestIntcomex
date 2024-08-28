using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product
    {
        [Key]
        public int Id_product { get; set; }
        public int sku { get; set; }
        public string mpn { get; set; }
        public string product_name { get; set; }

        public ICollection<Attribute_Value> Attributes_Value { get; set; }
        public ICollection<Product_Category> Product_Categories { get; set; }
        public ICollection<Product_Subcategory> Product_Subcategories { get; set; }
    }
}
