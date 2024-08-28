using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product_Category
    {
        [ForeignKey("Category")]
        public int Id_Category { get; set; }
        public Category Category { get; set; }
        [ForeignKey("Product")]
        public int Id_Product { get; set; }
        public Product Product { get; set; }
    }
}
