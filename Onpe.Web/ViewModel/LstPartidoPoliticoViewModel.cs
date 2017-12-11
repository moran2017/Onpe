using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;

namespace Onpe.Web.ViewModel
{

    public class LstPartidoPoliticoViewModel
    {

        public List<PartidoPolitico> LstPartidoPolitico { get; set; }
        public String Filtro { get; set; }

        public LstPartidoPoliticoViewModel()
        {
            ONPEEntities context = new ONPEEntities();

            LstPartidoPolitico = context.PartidoPolitico.ToList();
        }
        public void CargarDatos(String Filtro)
        {
            ONPEEntities context = new ONPEEntities();
            LstPartidoPolitico = context.PartidoPolitico.Where(X => X.Nombre.Contains(Filtro)).ToList();
        }
    }
}