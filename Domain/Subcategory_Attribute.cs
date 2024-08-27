using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Subcategory_Attribute
    {
        public int Id_Subcategory { get; set; }
        public Subcategory Subcategory { get; set; }
        public int Id_Attribute { get; set; }
        public Attribute Attribute { get; set; }
    }
}
