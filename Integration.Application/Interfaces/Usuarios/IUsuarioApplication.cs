using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Integration.Domain.Entities.Models;

namespace Integration.Application.Interfaces.Usuarios
{
    public interface IUsuarioApplication
    {
        IEnumerable<User> GetUser(User user);
        IEnumerable<User> Get(User user);
        IEnumerable<User> Get();
        User Get(Guid id);
        User Get(int id);
        void Add(User entity);
        void Delete(int id);
        void Update(User entity);
        int SaveChanges();
        IEnumerable<User> Find(Expression<Func<User, bool>> predicate);
    }
}
