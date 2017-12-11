using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;
namespace Onpe.Web.ViewModel
{
    public class AddEditUsuariosViewModel
    {
        public List<Usuario> LstUsuario { get; set; }
        public List<Roles> LstRoles { get; set; }
        public int ? UsuarioId { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public int RolId{ get; set; }
        public String Estado { get; set; }
        public String Codigo { get; set; }
        public String Password { get; set; }

        public void CargarDatos(int? UsuarioId)
        {
            ONPEEntities context = new ONPEEntities();
            this.UsuarioId = UsuarioId;
            this.LstRoles = context.Roles.ToList();

            if (UsuarioId.HasValue)
            {
                Usuario objUsuario = context.Usuario.FirstOrDefault(X=>X.UsuarioId==UsuarioId);
                this.Nombres = objUsuario.Nombres;
                this.Apellidos = objUsuario.Apellidos;
                this.RolId = objUsuario.RolId;
                this.Estado = objUsuario.Estado;
                this.Codigo = objUsuario.Codigo;
                this.Password = objUsuario.Password;
            }
        }

    }
}