using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Credito
    {
        [Key]
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int Empleados { get; set; }
        public decimal Activos { get; set; }
         public int CreditoFinal { get; set; }


    }
}
