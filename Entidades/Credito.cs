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
        public void CalculaEmpresa()
        {
            if (Empleados >= 10 && Activos < 501)
            {
                CreditoFinal = 100000000;
            }
            else if (Empleados >= 11 && Activos >= 501 && Empleados <= 50 && Activos <= 5000)
            {
                CreditoFinal = 150000000;
            }
            else if (Empleados >= 51 && Activos >= 5001 && Empleados <= 200 && Activos <= 15000)
            {
                CreditoFinal = 200000000;
            }


        }


    }
}
