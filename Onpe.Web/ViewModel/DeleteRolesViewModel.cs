using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;

namespace Onpe.Web.ViewModel
{
    public class DeleteRolesViewModel
    {
        public int? RolId { get; set; }


        public void CargarDatos(int? RolId)
        {
            this.RolId = RolId;

            if (RolId.HasValue)
            {
                ONPEEntities context = new ONPEEntities();
                Roles objCandidato = context.Roles.FirstOrDefault(X => X.RolId == RolId);

            }
        }
    }
}