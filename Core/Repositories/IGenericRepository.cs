﻿using System.Linq.Expressions;

namespace Project_OOP.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        Task<T> GetById(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        IQueryable<bool> Any(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
