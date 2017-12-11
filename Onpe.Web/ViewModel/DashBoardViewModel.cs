using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Onpe.Web.Models;


namespace Onpe.Web.ViewModel
{
    public class DashBoardViewModel
    {

        public int NroDistrito { get; set; }
        public int NroPartidoPolitico { get; set; }
        public int NroCandidato { get; set; }
        public int NroUsuarios { get; set; }
        public int NroRoles { get; set; }

        public DashBoardViewModel()
        {
            ONPEEntities context = new ONPEEntities();

            NroCandidato = context.Candidato.Count();
            NroDistrito = context.Distrito.Count();
            NroPartidoPolitico = context.PartidoPolitico.Count();
            NroUsuarios = context.Usuario.Count();
            NroRoles = context.Roles.Count();

        }

    }
}