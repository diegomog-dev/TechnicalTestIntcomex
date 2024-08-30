using Application.Repository.IRepository;
using Domain.Models;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class SubcategoryRepository : Repository<Subcategory>, ISubcategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public SubcategoryRepository(ApplicationDbContext context) :base(context)
        {
            _context = context;
        }
    }
}
