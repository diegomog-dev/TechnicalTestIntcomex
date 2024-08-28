using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Category_Characteristic
    {
        [ForeignKey("Category")]
        public int Id_Category { get; set; }
        public Category Category { get; set; }
        [ForeignKey("Characteristic")]
        public int Id_Characteristic { get; set; }
        public Characteristics Characteristic { get; set; }
    }
}
