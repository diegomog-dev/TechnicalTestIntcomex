using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category_Attribute
    {
        public int Id_Category { get; set; }
        public Category Category { get; set; }
        public int Id_Attribute { get; set; }
        public Attribute Attribute { get; set; }
    }
}
