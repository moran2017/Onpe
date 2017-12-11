using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;

namespace Onpe.Web.ViewModel
{
    public class LstRolesViewModel
    {

        public List<Roles> LstRoles { get; set; }
        public String Filtro { get; set; }

        public LstRolesViewModel()
        {
            ONPEEntities context = new ONPEEntities();
            LstRoles = context.Roles.ToList();
        }

        public void CargarDatos(String Filtro)
        {
            ONPEEntities context = new ONPEEntities();
            LstRoles = context.Roles.Where(X => X.Descripcion.Contains(Filtro)).ToList();
        }

    }
}