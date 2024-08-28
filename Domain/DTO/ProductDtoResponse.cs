using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class ProductDtoResponse
    {
        public List<ProductDto> Products { get; set; }
        public MetaData MetaData { get; set; }
    }
}
