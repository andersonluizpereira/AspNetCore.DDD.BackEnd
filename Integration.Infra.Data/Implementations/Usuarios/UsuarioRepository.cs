using System;
using System.Collections.Generic;
using System.Text;
using Integration.Domain.Entities.Interfaces.Usuarios;
using Integration.Domain.Entities.Models;
using Integration.Infra.Data.Contexts;
using Integration.Infra.Data.Repository;

namespace Integration.Infra.Data.Implementations.Usuarios
{
    public class UsuarioRepository : Repository<User>, IUsuarioRepository
    {
        public UsuarioRepository(Context context) : base(context)
        {

        }

        public IEnumerable<User> BuscarUsuario(User user)
        {
            return Find(u => u.UserID == user.UserID);
        }

        public IEnumerable<User> Logar(User use)
        {
           return Find(u=>u.UserID==use.UserID && u.AccessKey==use.AccessKey);
        }
    }
}
