using Application.Repository.IRepository;
using AutoMapper;
using Domain.DTO;
using Domain.Models;
using Domain.Specifications;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public readonly IMapper _mapper;

        public ProductRepository(ApplicationDbContext context, IMapper mapper): base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ProductDto>> Search(string parameter, int count, int pageNumber)
        {
            var paged = new Parameters
            {
                PageNumber = pageNumber,
                PageSize = count,
            };
            var products = new List<Product>();
            try
            {
                var categoryId = _context.Category.Where(c => EF.Functions.Like(c.Category_Name, $"%{parameter}%")).Select(c => (int)c.Id_Category).FirstOrDefault();
                var subcategoryId = _context.Subcategory.Where(sc => EF.Functions.Like(sc.Subcategory_Name, $"%{parameter}%")).Select(sc => (int)sc.Id_Subcategory).FirstOrDefault();                

                if(categoryId != 0)
                {
                    products = GetAllPaginate(paged, x => x.Product_Categories.Any(pc => pc.Id_Category == categoryId), includeProperties: "Attributes_Value.Attribute,Product_Categories.Category");
                }
                if(subcategoryId != 0)
                {
                    products = GetAllPaginate(paged, x => x.Product_Subcategories.Any(pc => pc.Id_Subcategory == subcategoryId), includeProperties: "Attributes_Value.Attribute,Product_Subcategories.Subcategory");
                }
                return _mapper.Map<List<ProductDto>>(products);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
