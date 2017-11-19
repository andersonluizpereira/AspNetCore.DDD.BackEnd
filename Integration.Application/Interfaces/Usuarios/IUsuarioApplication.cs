using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Integration.Domain.Entities.Models;

namespace Integration.Application.Interfaces.Usuarios
{
    public interface IUsuarioApplication
    {
        IEnumerable<UserViewModel> GetUser(UserViewModel user);
        IEnumerable<UserViewModel> Get(UserViewModel user);
        IEnumerable<UserViewModel> Get();
        UserViewModel Get(Guid id);
        UserViewModel Get(int id);
        void Add(UserViewModel entity);
        void Delete(int id);
        void Update(UserViewModel entity);
        int SaveChanges();
        IEnumerable<UserViewModel> Find(Expression<Func<UserViewModel, bool>> predicate);
    }
}
