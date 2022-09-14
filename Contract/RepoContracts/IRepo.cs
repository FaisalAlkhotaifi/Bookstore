using Domain.Common;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contract.RepoContracts
{
    public interface IRepo<T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync(int id);
        Task<T?> GetOneAsync(Expression<Func<T, bool>> filter);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>> filter);
        Task<PaginateObject<T>> GetPagedListAsync(int page, int size);
        Task<PaginateObject<T>> GetPagedListAsync(Expression<Func<T, bool>> filter, int page, int size);
        Task<bool> IsUniqueAsync(Expression<Func<T, bool>> comparison);
        Task<bool> IsExistAsync(Expression<Func<T, bool>> comparison);
        EntityEntry GetEntry(T entity);
        Task<int> GetCountAsync();
        Task<int> GetCountAsync(Expression<Func<T, bool>> filter);

        Task AddAsync(T entity);
        Task<T> AddAndSaveAsync(T entity);
        Task AddRangeAsync(List<T> entityList);
        Task<IReadOnlyList<T>> AddRangeAndSaveAsync(List<T> entityList);
        void Update(T entity);
        Task UpdateAndSaveAsync(T entity);
        void Delete(T entity);
        Task DeleteAndSaveAsync(T entity);
        void DeleteRange(IReadOnlyList<T> entity);
        Task DeleteRangeAndSaveAsync(IReadOnlyList<T> entity);
        Task SaveChangesAsync();
    }
}
