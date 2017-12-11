using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;
using System.ComponentModel.DataAnnotations;


namespace Onpe.Web.ViewModel
{
    public class LoginViewModel
    {

        public String Nombre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El Codigo no puede estar vacio.")]
        public String codigo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El password no puede estar vacio.")]
        public String password { get; set; }

        public LoginViewModel()
        {

        }
    }
}