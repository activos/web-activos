using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sistema.activos.web.ViewModels
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Ingrese su Cuenta de Usuario")]
        [DisplayName("Login:")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Ingrese su Password")]
        [DisplayName("Password:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}