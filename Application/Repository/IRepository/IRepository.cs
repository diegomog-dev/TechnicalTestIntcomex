using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository.IRepository
{
    public interface IRepository <T>where T : class
    {
        Task Create (T entity);
        Task<List<T>> GetAll (Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        Task<T> Get(Expression<Func<T, bool>>? filter = null,bool tracked = true, string? includeProperties = null);
        Task Remove(T entity);
        Task Save();
    }
}
