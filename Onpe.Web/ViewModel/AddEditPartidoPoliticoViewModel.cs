using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;

namespace Onpe.Web.ViewModel
{
    public class AddEditPartidoPoliticoViewModel
    {

        public int? PartidoPoliticoId { get; set; }
        public String Nombre { get; set; }

        public void CargarDatos(int? PartidoPoliticoId)
        {
            this.PartidoPoliticoId = PartidoPoliticoId;

            if(PartidoPoliticoId.HasValue)
            {
                ONPEEntities context = new ONPEEntities();
                PartidoPolitico objPartidoPolitico = context.PartidoPolitico.FirstOrDefault
                    (X => X.PartidoPoliticoId == PartidoPoliticoId);
                this.Nombre = objPartidoPolitico.Nombre;

            }
            
        }


    }
}