using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product_Subcategory
    {
        [ForeignKey("Product")]
        public int Id_Product { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Subcategory")]
        public int Id_Subcategory { get; set; }
        public Subcategory Subcategory { get; set; }
    }
}
