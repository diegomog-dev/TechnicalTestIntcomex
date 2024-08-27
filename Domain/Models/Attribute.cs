using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Attribute
    {
        [Key]
        public int Id_Attribute { get; set; }
        public string Attribute_Name { get; set; }

        public ICollection<Attribute_Value> Value { get; set; }
        public ICollection<Category_Attribute> Attribute_Categories { get; set; }
        public ICollection<Subcategory_Attribute> Attribute_Subcategories { get; set; }
    }
}
