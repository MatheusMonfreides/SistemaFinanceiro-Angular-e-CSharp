using SistemaFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
        Task ExecuteInTransactionAsync(Action action);
        void Insert(TEntity obj);

        void Update(TEntity obj);

        void Delete(int id);

        IList<TEntity> Select();

        TEntity Select(int id);

        IQueryable<TEntity> SelectByCondition(Expression<Func<TEntity, bool>> expression);

        //Task <IList<TEntity>> SelectAsync();

        Task<IList<TEntity>> SelectAsync(params Expression<Func<TEntity, object>>[] includes);
        //IQueryable<TEntity> SelectAsync();
        IQueryable<TEntity> SelectAllAsync();
        Task<TEntity> SelectAsync(Guid id);

        Task SaveAsync(TEntity obj);

        Task InsertAsync(TEntity obj);

        Task UpdateAsync(TEntity obj);

        Task DeleteAsync(Guid id);
        Task InsertRangeAsync(IList<TEntity> obj);

        void Dispose();
        Task DisposeAsync();
    }
}
