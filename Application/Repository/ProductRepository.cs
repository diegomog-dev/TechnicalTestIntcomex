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

        public async Task<ProductDtoResponse> Search(string parameter, int count, int pageNumber)
        {
            var paged = new Parameters
            {
                PageNumber = pageNumber,
                PageSize = count,
            };
            PagedList<Product> products = null;
            List<ProductDto> listProducts = new List<ProductDto>();
            MetaData metaData = null;

            try
            {
                var categoryId = await _context.Category.Where(c => EF.Functions.Like(c.Category_Name, $"%{parameter}%"))
                                                        .Select(c => (int)c.Id_Category)
                                                        .FirstOrDefaultAsync();
                var subcategoryId = await _context.Subcategory.Where(sc => EF.Functions.Like(sc.Subcategory_Name, $"%{parameter}%"))
                                                              .Select(sc => (int)sc.Id_Subcategory)
                                                              .FirstOrDefaultAsync();                

                if(categoryId != 0)
                {
                    products = GetAllPaginate(paged, x => x.Product_Categories.Any(pc => pc.Id_Category == categoryId),
                        includeProperties: "Characteristics_Value.Characteristic,Product_Categories.Category");
                    metaData = products.MetaData;
                    listProducts = _mapper.Map<List<ProductDto>>(products);

                }
                else if(subcategoryId != 0)
                {
                    products = GetAllPaginate(paged, x => x.Product_Subcategories.Any(pc => pc.Id_Subcategory == subcategoryId),
                        includeProperties: "Characteristics_Value.Characteristic,Product_Subcategories.Subcategory");
                    metaData = products.MetaData;
                    listProducts = _mapper.Map<List<ProductDto>>(products);
                }               

                return new ProductDtoResponse
                {
                    Products = listProducts,
                    MetaData = metaData
                };

            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar productos", ex);
            }
        }
    }
}