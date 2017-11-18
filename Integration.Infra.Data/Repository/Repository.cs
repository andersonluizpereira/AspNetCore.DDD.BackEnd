using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Integration.Infra.Data.Contexts;
using Integration.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Integration.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected Context _dataContext;
        protected DbSet<TEntity> DbSet;

        public Repository(Context context)
        {
            this._dataContext = context;
            this.DbSet = this._dataContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            this.DbSet.Add(entity);
        }

        public void Delete(int id)
        {
            this._dataContext.Entry(this.DbSet.Find(id)).State = EntityState.Deleted;

        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return this.DbSet.AsNoTracking().Where(predicate);
        }

        public IEnumerable<TEntity> Get()
        {
            return this.DbSet.ToList();
        }

        public TEntity Get(Guid id)
        {
            return this.DbSet.Find(id);
        }

        public TEntity Get(int id)
        {
            return this.DbSet.Find(id);
        }

        public int SaveChanges()
        {
            return this._dataContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            if (this._dataContext.Entry(entity).State == EntityState.Detached)
            {
                this._dataContext.Set<TEntity>().Attach(entity);
            }
            this._dataContext.Entry(entity).State = EntityState.Modified;
            this._dataContext.SaveChanges();

        }

        public void Dispose()
        {
            this._dataContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
