using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Characteristic_Value
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int Id_Product { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Characteristic")]
        public int Id_Characteristic { get; set; }
        public Characteristics Characteristic { get; set; }
        public string Value { get; set; }
    }
}
