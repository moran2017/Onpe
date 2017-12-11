using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;

namespace Onpe.Web.ViewModel
{
    public class DeleteCandidatoViewModel
    {

        public int ? CandidatoId { get; set; }
       

        public void CargarDatos(int? CandidatoId)
        {
            this.CandidatoId = CandidatoId;

            if (CandidatoId.HasValue)
            {
                ONPEEntities context = new ONPEEntities();
                Candidato objCandidato = context.Candidato.FirstOrDefault(X => X.CandidatoId == CandidatoId);
               
            }
        }
    }
}