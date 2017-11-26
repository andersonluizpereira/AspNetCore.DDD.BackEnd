using System;
using System.Collections.Generic;
using System.Text;
using Integration.Domain.Entities.Models;

namespace Integration.Domain.Entities.Interfaces.Usuarios
{
   public interface IUsuarioRepository
   {
       IEnumerable<User> Logar(User user);
       IEnumerable<User> BuscarUsuario(User user);
    }
}
