using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;

namespace Onpe.Web.ViewModel
{
    public class DeleteUsuarioViewModel
    {

        public int? UsuarioId { get; set; }

        public void CargarDatos(int? UsuarioId)
        {
            this.UsuarioId = UsuarioId;

            if (UsuarioId.HasValue)
            {
                ONPEEntities context = new ONPEEntities();
                Usuario objUsuario = context.Usuario.FirstOrDefault(X => X.UsuarioId == UsuarioId);

            }
        }
    }
}