﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Onpe.Web.Models;

namespace Onpe.Web.ViewModel
{
    public class DeleteDistritoViewModel
    {
        public int? DistritoId { get; set; }


        public void CargarDatos(int? DistritoId)
        {
            this.DistritoId = DistritoId;

            if (DistritoId.HasValue)
            {
                ONPEEntities context = new ONPEEntities();
                Distrito objDistrito = context.Distrito.FirstOrDefault(X => X.DistritoId == X.DistritoId);

            }
        }
    }
}
