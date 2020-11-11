using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Datos;
using Entidades;
using Logica;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using parcial2.Models;

namespace parcial2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreditoController : ControllerBase
    {
        private readonly CreditoService _creditoService;
        public IConfiguration Configuration { get; }
        public CreditoController(CreditoContext context)
        {
            _creditoService = new CreditoService(context);
        }
        // GET: api/Credito
        [HttpGet]
        public IEnumerable<CreditoViewModel> Gets()
        {
            var creditos = _creditoService.ConsultarTodos().Select(p => new CreditoViewModel(p));
            return creditos;
        }
        // GET: api/Credito/5
        [HttpGet("{identificacion}")]
        public ActionResult<CreditoViewModel> Get(string identificacion)
        {
            var credito = _creditoService.BuscarxIdentificacion(identificacion);
            if (credito == null) return NotFound();
            var personaViewModel = new CreditoViewModel(credito);
            return personaViewModel;
        }
        private Credito MapearCredito(CreditoInputModel creditoInput)
        {
            var credito = new Credito
            {
                Identificacion = creditoInput.Identificacion,
                Nombre = creditoInput.Nombre,
                Empleados = creditoInput.Empleados,
                Activos = creditoInput.Activos,
                CreditoFinal=creditoInput.CreditoFinal
            };
            return credito;
        }
        // POST: api/Credito
        [HttpPost]
        public ActionResult<CreditoViewModel> Post(CreditoInputModel creditoInput)
        {
            Credito credito = MapearCredito(creditoInput);
            var response = _creditoService.Guardar(credito);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Credito);
        }
        // DELETE: api/Credito/5
        [HttpDelete("{identificacion}")]
        public ActionResult<string> Delete(string identificacion)
        {
            string mensaje = _creditoService.Eliminar(identificacion);
            return Ok(mensaje);
        }

    }
}

