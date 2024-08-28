using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Subcategory_Attribute
    {
        [ForeignKey("Subcategory")]
        public int Id_Subcategory { get; set; }
        public Subcategory Subcategory { get; set; }
        [ForeignKey("Attribute")]
        public int Id_Attribute { get; set; }
        public Attribute Attribute { get; set; }
    }
}
