﻿using System;
using System.Collections.Generic;
using System.Linq;
using Datos;
using Entidades;

namespace Logica
{
    public class CreditoService
    {
          private readonly CreditoContext _context;
        public CreditoService(CreditoContext context)
        {
            _context = context;
        }
        
        public GuardarCreditoResponse Guardar(Credito credito)
        {
            try
            {
                var creditoBuscada = _context.creditos.Find(credito.Identificacion);

                if (creditoBuscada != null)
                {
                    return new GuardarCreditoResponse("Error, ya esta registrado");
                }
               
                _context.creditos.Add(credito);
                _context.SaveChanges();

                return new GuardarCreditoResponse(credito);
            }
            catch (Exception e)
            {
                return new GuardarCreditoResponse($"Error de la Aplicacion: {e.Message}");
            }

        }
        public List<Credito> ConsultarTodos()
        {
            List<Credito> creditos = _context.creditos.ToList();

            return creditos;
        }
        public string Modificar(Credito creditoNueva)
        {
            try
            {

                var creditoVieja =_context.creditos.Find(creditoNueva.Identificacion);
                if (creditoVieja != null)
                {
                    creditoVieja.Nombre = creditoNueva.Nombre;
                    creditoVieja.Identificacion = creditoNueva.Identificacion;
                    creditoVieja.Empleados = creditoNueva.Empleados;
                    creditoVieja.Activos = creditoNueva.Activos;
                    _context.creditos.Update(creditoNueva);
                    _context.SaveChanges();

                    return ($"El registro {creditoNueva.Nombre} se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {creditoNueva.Identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
        }
        public string Eliminar(string identificacion)
        {
            try
            {

                var credito = _context.creditos.Find(identificacion);

                if (credito != null)
                {
                    _context.creditos.Remove(credito);
                    _context.SaveChanges();


                    return ($"El registro {credito.Nombre} se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }


        }
        public Credito BuscarxIdentificacion(string identificacion)
        {
            var credito = _context.creditos.Find(identificacion);

            return credito;
        }
        public int Totalizar()
        {
            return _context.creditos.Count();
        }
      /*  public int TotalizarPagado()
        {
            return _context.creditos.Count(p => p.Estado == "Pagado");
        }
        public int TotalizarDebe()
        {
            return _context.creditos.Count(p => p.Estado == "Debe");
        }
        public int TotalizarDebe()
        {
            return _context.creditos.Count(p => p.Estado == "Debe");
        }
    }*/

    public class GuardarCreditoResponse
    {
        public GuardarCreditoResponse(Credito credito)
        {
            Error = false;
            Credito = credito;
        }
        public GuardarCreditoResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Credito Credito { get; set; }
    }
    }
}
