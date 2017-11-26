using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Integration.Application.Interfaces.Usuarios;
using Integration.Domain.Entities.Interfaces.Usuarios;
using Integration.Domain.Entities.Models;

namespace Integration.Application.Implementations.Usuarios
{
    public class UsuarioApplication : IUsuarioApplication
    {
        private readonly IUsuarioRepository _iUsuarioRepository;

        public UsuarioApplication(IUsuarioRepository iUsuarioRepository)
        {
            _iUsuarioRepository = iUsuarioRepository;
        }

        public IEnumerable<User> Get(User user)
        {
            return _iUsuarioRepository.Logar(user);
        }

        public IEnumerable<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Find(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUser(User user)
        {
            return _iUsuarioRepository.BuscarUsuario(user);
        }
    }
}
