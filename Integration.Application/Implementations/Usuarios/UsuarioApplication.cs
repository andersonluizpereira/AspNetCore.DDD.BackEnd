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

        public IEnumerable<UserViewModel> Get(UserViewModel user)
        {
            return _iUsuarioRepository.Logar(user);
        }

        public IEnumerable<UserViewModel> Get()
        {
            throw new NotImplementedException();
        }

        public UserViewModel Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public UserViewModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(UserViewModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserViewModel entity)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserViewModel> Find(Expression<Func<UserViewModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserViewModel> GetUser(UserViewModel user)
        {
            return _iUsuarioRepository.BuscarUsuario(user);
        }
    }
}
