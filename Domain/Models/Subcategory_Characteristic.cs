using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Subcategory_Characteristic
    {
        [ForeignKey("Subcategory")]
        public int Id_Subcategory { get; set; }
        public Subcategory Subcategory { get; set; }
        [ForeignKey("Characteristic")]
        public int Id_Characteristic { get; set; }
        public Characteristics Characteristic { get; set; }
    }
}
