using Contract.RepoContracts;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Model.Common;
using Persistence.Utilities.PaginatorUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repos
{
    public class Repo<T> : IRepo<T> where T : BaseEntity
    {
        protected readonly AppDbContext _dbContext;

        public Repo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T?> GetOneAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(filter);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbContext.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<PaginateObject<T>> GetPagedListAsync(int page, int size)
        {
            var source = _dbContext.Set<T>().OrderByDescending(o => o.UpdatedDate ?? o.CreatedDate);
            return await Paginator<T>.Create(source, page, size);
        }

        public async Task<PaginateObject<T>> GetPagedListAsync(Expression<Func<T, bool>> filter, int page, int size)
        {
            var source = _dbContext.Set<T>().Where(filter).OrderByDescending(o => o.UpdatedDate ?? o.CreatedDate);
            return await Paginator<T>.Create(source, page, size);
        }

        public async Task<bool> IsUniqueAsync(Expression<Func<T, bool>> comparison)
        {
            var isUnique = !(await _dbContext.Set<T>().AnyAsync(comparison));

            return isUnique;
        }

        public async Task<bool> IsExistAsync(Expression<Func<T, bool>> comparison)
        {
            var matches = await _dbContext.Set<T>().AnyAsync(comparison);
            return matches;
        }

        public EntityEntry GetEntry(T entity)
        {
            return _dbContext.Entry(entity);
        }

        public async Task<int> GetCountAsync()
        {
            return await _dbContext.Set<T>().CountAsync();
        }

        public async Task<int> GetCountAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbContext.Set<T>().Where(filter).CountAsync();
        }


        public async Task AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
        }

        public async Task<T> AddAndSaveAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task AddRangeAsync(List<T> entityList)
        {
            await _dbContext.Set<T>().AddRangeAsync(entityList);
        }

        public async Task<IReadOnlyList<T>> AddRangeAndSaveAsync(List<T> entityList)
        {
            await _dbContext.Set<T>().AddRangeAsync(entityList);
            await _dbContext.SaveChangesAsync();

            return entityList;
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task UpdateAndSaveAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public async Task DeleteAndSaveAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public void DeleteRange(IReadOnlyList<T> entity)
        {
            _dbContext.Set<T>().RemoveRange(entity);
        }

        public async Task DeleteRangeAndSaveAsync(IReadOnlyList<T> entity)
        {
            _dbContext.Set<T>().RemoveRange(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
