using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema.activos.entidades;
using sistema.activos.repository;

namespace sistema.activos.model
{
    public class UsuariosModulo
    {
        public bool ValidarUsuario(UsuarioEntity usuario)
        {
            var result = false;
            using (var context = new ActivosModel())
            {
                var usuarios = context.Usuarios;
                string login = usuario.Login;
                string password = usuario.Password;
                result = usuarios.Any(user => user.Login.Equals(login) && user.Password.Equals(password));
            }
            return result;
        }
    }
}
