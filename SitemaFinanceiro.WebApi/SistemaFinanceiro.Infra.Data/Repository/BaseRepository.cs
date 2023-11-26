using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Infra.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly EfDbContext _mySqlContext;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(EfDbContext mySqlContext)
        {
            _mySqlContext = mySqlContext;
            DbSet = _mySqlContext.Set<TEntity>();
        }



        public async Task BeginTransactionAsync()
        {
            if (_mySqlContext.Database.CurrentTransaction == null)
            {
                await _mySqlContext.Database.BeginTransactionAsync();
            }
        }

        public async Task CommitTransactionAsync()
        {
            if (_mySqlContext.Database.CurrentTransaction != null)
            {
                await _mySqlContext.Database.CurrentTransaction.CommitAsync();
            }
        }

        public async Task RollbackTransactionAsync()
        {
            if (_mySqlContext.Database.CurrentTransaction != null)
            {
                await _mySqlContext.Database.CurrentTransaction.RollbackAsync();
            }
        }
        public async Task ExecuteInTransactionAsync(Action action)
        {
            using var transaction = await _mySqlContext.Database.BeginTransactionAsync();

            try
            {
                action(); // Execute a ação dentro da transação.
                await transaction.CommitAsync(); // Comite a transação se não houver erros.
            }
            catch (Exception)
            {
                await transaction.RollbackAsync(); // Reverta a transação em caso de erro.
                throw;
            }
        }


        public void Insert(TEntity obj)
        {
            obj.CreatedAt = DateTime.Now;
            _mySqlContext.Set<TEntity>().Add(obj);
            _mySqlContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            obj.UpdatedAt = DateTime.Now;
            _mySqlContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _mySqlContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _mySqlContext.Set<TEntity>().Remove(Select(id));
            _mySqlContext.SaveChanges();
        }

        public IList<TEntity> Select() =>
            //_mySqlContext.Set<TEntity>().ToList();
            _mySqlContext.Set<TEntity>().AsNoTracking().ToList();

        public TEntity Select(int id) =>
            _mySqlContext.Set<TEntity>().Find(id);




        public IQueryable<TEntity> SelectAllAsync()
        {
            return _mySqlContext.Set<TEntity>();
        }
        public async Task<TEntity> SelectAsync(Guid id) =>
           await _mySqlContext.Set<TEntity>().FindAsync(id);

        public async Task<IList<TEntity>> SelectAsync(params Expression<Func<TEntity, object>>[] includes)
        {
            var query = _mySqlContext.Set<TEntity>().AsNoTracking();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.ToListAsync();
        }

        public IQueryable<TEntity> SelectByCondition(Expression<Func<TEntity, bool>> expression) =>
           _mySqlContext.Set<TEntity>().Where(expression).AsNoTracking();



        public async Task SaveAsync(TEntity obj)
        {
            if (obj.Id == new Guid())
                await InsertAsync(obj);
            else
                await UpdateAsync(obj);
        }

        public async Task InsertAsync(TEntity obj)
        {
            await _mySqlContext.Set<TEntity>().AddAsync(obj);
            await _mySqlContext.SaveChangesAsync();
        }

        public async Task InsertRangeAsync(IList<TEntity> obj)
        {
            await _mySqlContext.Set<TEntity>().AddRangeAsync(obj);
            await _mySqlContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity obj)
        {
            _mySqlContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _mySqlContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            _mySqlContext.Set<TEntity>().Remove(await SelectAsync(id));
            await _mySqlContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _mySqlContext.Dispose();
            GC.SuppressFinalize(this);
        }
        public async Task DisposeAsync()
        {
            await _mySqlContext.DisposeAsync();
            GC.SuppressFinalize(this);
        }
    }
}
