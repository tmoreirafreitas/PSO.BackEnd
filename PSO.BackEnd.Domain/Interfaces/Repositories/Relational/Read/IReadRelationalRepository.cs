﻿using PSO.BackEnd.Domain.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PSO.BackEnd.Domain.Interfaces.Repositories.Relational.Read
{
    public interface IReadRelationalRepository<TEntity> where TEntity : Entity
    {
        Task<IQueryable<TEntity>> GetAllAsync();
        Task<IQueryable<TEntity>> GetAllAsync(int page, int pageSize);
        Task<IQueryable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetByIdAsync(long id);
        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> expression);
        Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> expression);
    }
}