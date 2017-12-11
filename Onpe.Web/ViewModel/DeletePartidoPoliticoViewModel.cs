using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;

namespace Onpe.Web.ViewModel
{
    public class DeletePartidoPoliticoViewModel
    {
        public int? PartidoPoliticoId { get; set; }
       
        public void CargarDatos(int? PartidoPoliticoId)
        {
            this.PartidoPoliticoId = PartidoPoliticoId;

            if (PartidoPoliticoId.HasValue)
            {
                ONPEEntities context = new ONPEEntities();
                PartidoPolitico objPartidoPolitico = context.PartidoPolitico.FirstOrDefault(X => 
                X.PartidoPoliticoId == X.PartidoPoliticoId);             

            }
        }
    }
}