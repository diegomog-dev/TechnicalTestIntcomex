using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Subcategory
    {
        [Key]
        public int Id_Subcategory { get; set; }
        public string Subcategory_Name { get; set; }
        [ForeignKey("Category")]
        public int Id_Category { get; set; }
        public Category Category { get; set; }

        public ICollection<Product_Subcategory> Subcategory_Products { get; set; }
        public ICollection<Subcategory_Characteristic> Subcategory_Characteristics { get; set; }
    }
}
