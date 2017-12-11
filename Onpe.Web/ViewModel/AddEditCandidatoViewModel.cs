using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;

namespace Onpe.Web.ViewModel
{
    public class AddEditCandidatoViewModel
    {

       public int? CandidatoId { get; set; }
       public String Nombre { get; set; }
       public String Apellidos { get; set; }
       public int DistritoId { get; set; }
       public int PartidoPoliticoId { get; set; }
       public List<Distrito> LstDistrito { get; set; }
        public List<PartidoPolitico> LstPartidoPolitico { get; set; }

        public void CargarDatos(int? CandidatoId)
        {
            ONPEEntities context = new ONPEEntities();
            this.CandidatoId = CandidatoId;
            this.LstDistrito = context.Distrito.ToList();
            this.LstPartidoPolitico = context.PartidoPolitico.ToList();

            if (CandidatoId.HasValue)
            {
                Candidato objCandidato = context.Candidato.FirstOrDefault(X => X.CandidatoId == CandidatoId);

                this.Nombre = objCandidato.Nombre;
                this.Apellidos = objCandidato.Apellidos;
                this.DistritoId = objCandidato.DistritoId;
                this.PartidoPoliticoId = objCandidato.PartidoPoliticoId;
            }
        }





    }
}