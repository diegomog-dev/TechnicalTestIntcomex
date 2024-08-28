using Domain.DTO;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<ProductDto>> Search(string parameter, int count, int pageNumber);
    }
}
