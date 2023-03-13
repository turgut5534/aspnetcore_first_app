using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IService<T> where T: class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();

        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        IQueryable<T> AnyAsync(Expression<Func<T, bool>> expression);

        Task AddSync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        void UpdateSync(T entity);

        void RemoveAsync(T entity);

        void RemoveRangeAsync(IEnumerable<T> entities);
    }
}
