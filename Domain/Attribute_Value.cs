using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Attribute_Value
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int Id_Product { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Attribute")]
        public int Id_Attribute { get; set; }
        public Attribute Attribute { get; set; }
        public string Value { get; set; }
    }
}
