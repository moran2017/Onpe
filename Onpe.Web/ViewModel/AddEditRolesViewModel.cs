using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;

namespace Onpe.Web.ViewModel
{
    public class AddEditRolesViewModel
    {
        public int? RolId { get; set; }
        public String Acronimo { get; set; }
        public String Descripcion { get; set; }

        public void CargarDatos(int? RolId)
        {
            ONPEEntities context = new ONPEEntities();
            this.RolId = RolId;

            if (RolId.HasValue)
            {
                Roles objRoles = context.Roles.FirstOrDefault(X => X.RolId == RolId);

                this.Acronimo = objRoles.Acronimo;
                this.Descripcion = objRoles.Descripcion;

            }
        }
    }
}