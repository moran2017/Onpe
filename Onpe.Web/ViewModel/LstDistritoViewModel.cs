using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;

namespace Onpe.Web.ViewModel
{
    public class LstDistritoViewModel
    {
        public List<Distrito> LstDistrito { get; set; }
        public String Filtro { get; set; }

        public LstDistritoViewModel()
        {
            ONPEEntities context = new ONPEEntities();

            LstDistrito = context.Distrito.ToList();
        }

        public void CargarDatos(String Filtro)
        {
            ONPEEntities context = new ONPEEntities();
            LstDistrito = context.Distrito.Where(X => X.Nombre.Contains(Filtro)).ToList();
        }
    }
}