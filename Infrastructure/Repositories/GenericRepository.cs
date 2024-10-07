﻿using Application.CustomExceptions;
using Application.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbSet<T> _db;
        protected readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _db.AddAsync(entity);
        }

        public async Task<int> CountAsync() => await _db.CountAsync();
        public async Task<List<T>> GetAllAsync(System.Linq.Expressions.Expression<Func<T, bool>>? filter, 
                                               Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
        {
            IQueryable<T> query = _db;


            if (filter != null)
            {
                query = query.Where(filter);
            }

            //query.IgnoreQueryFilters();

            if (include != null)
            {
                query = include(query);
            }
            return await query.ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(System.Linq.Expressions.Expression<Func<T, bool>>? filter)
        {
            if (filter != null)
            {
                return await _db.Where(filter).ToListAsync();
            }
            return await _db.ToListAsync();
        }

        public async Task<T> GetAsync(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
#nullable disable
            IQueryable<T> query = _db;
            return await query.FirstOrDefaultAsync(filter);
#nullable restore
        }

        public async Task<T> GetAsync(System.Linq.Expressions.Expression<Func<T, bool>> filter, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
        {

            IQueryable<T> query = _db;
            if (include != null)
            {
                query = include(query);
            }
            return await query.FirstOrDefaultAsync(filter);

        }

        public async Task RemoveByIdAsync(object id)
        {
#nullable disable
            T existing = await _db.FindAsync(id);
#nullable restore
            if (existing != null)
            {
                _db.Remove(existing);
            }
            else throw new Exception();
        }

        public async Task AddRangeAsync(List<T> entities)
        {
            await _db.AddRangeAsync(entities);
        }
    }
}
