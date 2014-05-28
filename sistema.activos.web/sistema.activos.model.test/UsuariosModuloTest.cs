using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sistema.activos.entidades;

namespace sistema.activos.model.test
{
    [TestClass]
    public class UsuariosModuloTest
    {
        [TestMethod]
        public void ValidarUsuarioNoExistenteTest()
        {
            UsuariosModulo modulo = new UsuariosModulo();
            UsuarioEntity usuario = new UsuarioEntity{Login = "", Password = ""};
            var result = modulo.ValidarUsuario(usuario);
            
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidarUsuarioExistenteTest()
        {
            UsuariosModulo modulo = new UsuariosModulo();
            UsuarioEntity usuario = new UsuarioEntity { Login = "admin", Password = "admin" };
            var result = modulo.ValidarUsuario(usuario);

            Assert.IsTrue(result);
        }
    }
}
