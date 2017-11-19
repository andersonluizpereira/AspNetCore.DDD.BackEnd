using System;
using System.Collections.Generic;
using System.Text;
using Integration.Domain.Entities.Interfaces.Usuarios;
using Integration.Domain.Entities.Models;
using Integration.Infra.Data.Contexts;
using Integration.Infra.Data.Repository;

namespace Integration.Infra.Data.Implementations.Usuarios
{
    public class UsuarioRepository : Repository<UserViewModel>, IUsuarioRepository
    {
        public UsuarioRepository(Context context) : base(context)
        {

        }

        public IEnumerable<UserViewModel> BuscarUsuario(UserViewModel user)
        {
            return Find(u => u.UserID == user.UserID);
        }

        public IEnumerable<UserViewModel> Logar(UserViewModel use)
        {
           return Find(u=>u.UserID==use.UserID && u.AccessKey==use.AccessKey);
        }
    }
}
