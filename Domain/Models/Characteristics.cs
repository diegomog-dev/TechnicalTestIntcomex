using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Characteristics
    {
        [Key]
        public int Id_Characteristic { get; set; }
        public string Characteristic_Name { get; set; }

        public ICollection<Characteristic_Value> Characteristic { get; set; }
        public ICollection<Category_Characteristic> Characteristic_Categories { get; set; }
        public ICollection<Subcategory_Characteristic> Characteristic_Subcategories { get; set; }
    }
}
