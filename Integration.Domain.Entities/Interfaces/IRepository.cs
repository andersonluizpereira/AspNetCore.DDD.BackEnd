using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Integration.Domain.Entities.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T Get(Guid id);
        T Get(int id);
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        int SaveChanges();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
