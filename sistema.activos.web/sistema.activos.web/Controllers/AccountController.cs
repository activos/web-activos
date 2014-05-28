using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using sistema.activos.entidades;
using sistema.activos.model;
using sistema.activos.web.ViewModels;

namespace sistema.activos.web.Controllers
{
    public class AccountController : Controller
    {
        private UsuariosModulo usuariosModulo = new UsuariosModulo();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLoginViewModel model)
        {
            // Lets first check if the Model is valid or not
            if (ModelState.IsValid)
            {
                var usuario = new UsuarioEntity { Login = model.Login, Password = model.Password };
                bool userValid = usuariosModulo.ValidarUsuario(usuario);

                // User found in the database
                if (userValid)
                {

                    FormsAuthentication.SetAuthCookie(model.Login, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "The user name or password provided is incorrect.");
                }

            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        public ActionResult CerrarSesion()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login", "Account");
        }

    }
}
