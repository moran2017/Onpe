using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;

namespace Onpe.Web.ViewModel
{
    public class LstUsuariosViewModel
    {

        public List<Usuario> LstUsuarios { get; set; }
       
        public String Filtro { get; set; }

        public LstUsuariosViewModel()
        {
            ONPEEntities context = new ONPEEntities();
            LstUsuarios = context.Usuario.ToList();
        }

        public void CargarDatos(String Filtro)
        {
            ONPEEntities context = new ONPEEntities();
            LstUsuarios = context.Usuario.Where(X => X.Nombres.Contains(Filtro)).ToList();
        }

    }
}