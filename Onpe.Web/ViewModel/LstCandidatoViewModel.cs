using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;

namespace Onpe.Web.ViewModel
{
    public class LstCandidatoViewModel
    {

        public List<Candidato> LstCandidato { get; set; }
        
        public String Filtro { get; set; }


        public LstCandidatoViewModel()
        {
            ONPEEntities context = new ONPEEntities();
           LstCandidato = context.Candidato.ToList();

        } 
        
        public void CargarDatos (String Frilto)
        {
            ONPEEntities context = new ONPEEntities();
            LstCandidato = context.Candidato.Where(X => X.Nombre.Contains(Filtro)).ToList();
        }
           
           

        

     
    }
}