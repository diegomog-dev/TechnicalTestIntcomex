using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class ProductDto
    {
        public int sku { get; set; }
        public string mpn { get; set; }
        public string product_name { get; set; }
        public List<AttributeDto> AttributesList { get; set; }
    }
}
