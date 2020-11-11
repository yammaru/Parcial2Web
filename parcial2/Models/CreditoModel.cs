
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parcial2.Models
{
    public class CreditoInputModel
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int Empleados { get; set; }
        public decimal Activos { get; set; }
        
    }

    public class CreditoViewModel : CreditoInputModel
    {
        public CreditoViewModel()
        {

        }
        public CreditoViewModel(Credito credito)
        {
            Identificacion = credito.Identificacion;
            Nombre = credito.Nombre;
            Empleados = credito.Empleados;
            Activos = credito.Activos;
            CreditoFinal=credito.CreditoFinal;
             
        }
        public int CreditoFinal { get; set; }
    }
}
