using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        T GetBy(string id);
        IEnumerable<T> GetAll();
        //IEnumerable<T> Find(ISpecification<T> spec);

        void Add(T entity);
        void Remove(T entity);

        void AddRange(IEnumerable<T> entities);
        void RemoveRange(IEnumerable<T> entities);

        Task<T> GetByAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(IEnumerable<T> entities);

        int Count();
    }
}