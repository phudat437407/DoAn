using ApplicationCore.Interfaces;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq; // ToList() thuoc Linq
using System.Threading.Tasks;
using System;
using System.Linq.Expressions;

namespace Infrastructure.Persistence.Repository
{
    public class EFRepository<T> : IRepository<T> where T : class, IAggregateRoot // class ???
    {
        private readonly DbContext _context;

        public EFRepository(DbContext context)
        {
            _context = context;
        }

        protected DbContext Context => _context;

        public T GetBy(string id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

       /* public IEnumerable<T> Find(ISpecification<T> spec)
        {
            //return ApplySpecification(_context.Set<T>().AsQueryable(), spec);
    
        }*/

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public int Count()
        {
            return _context.Set<T>().Count();
        }

        // Async    =========================================================================================
        public async Task AddAsync(T entity)
        {
            try
            {
                await Context.AddAsync(entity);
            }
            catch (Exception e)
            {
                Console.WriteLine("Add() Unexpected: " + e);
            }
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                await Context.AddRangeAsync(entities);
            }
            catch (Exception e)
            {
                Console.WriteLine("AddRange() Unexpected: " + e);
            }

        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return await Context.Set<T>().AsNoTracking().Where(predicate).ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine("Find() Unexpected: " + e);
                return null;
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await Context.Set<T>().AsNoTracking().ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine("GetAll() Unexpected: " + e);
                return null;
            }
        }

        public async Task<T> GetByAsync(string id)
        {
            try
            {
                return await Context.Set<T>().FindAsync(id);
            }
            catch (Exception e)
            {
                Console.WriteLine("GetBy() Unexpected: " + e);
                return null;
            }
        }

        public async Task RemoveAsync(T entity)
        {

            try
            {
                await Task.Run(() => Context.Set<T>().Remove(entity));
            }
            catch (Exception e)
            {
                Console.WriteLine("Remove() Unexpected: " + e);
            }
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                await Task.Run(() => Context.Set<T>().RemoveRange(entities));
            }
            catch (Exception e)
            {
                Console.WriteLine("RemoveRange() Unexpected: " + e);
            }

        }

        public async Task UpdateAsync(T entity)
        {

            try
            {
                await Task.Run(() => Context.Set<T>().Update(entity));
            }
            catch (Exception e)
            {
                Console.WriteLine("UpdateAsync() Unexpected: " + e);
            }
        }

        public async Task UpdateRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                await Task.Run(() => Context.Set<T>().UpdateRange(entities));
            }
            catch (Exception e)
            {
                Console.WriteLine("UpdateRangeAsync() Unexpected: " + e);
            }
        }
    }
}