using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Category
    {
        [Key]
        public int Id_Category { get; set; }
        public string Category_Name { get; set; }

        public ICollection<Subcategory> Subcategories { get; set; }
        public ICollection<Product_Category> Category_Products { get; set; }
        public ICollection<Category_Attribute> Category_Attributes { get; set; }
    }
}
