using DAL.Repositories;
using System;
using System.Web.Http;

namespace ExamenNet.Controllers.api
{
    public class VentasController : ApiController
    {
        [HttpGet]
        public IHttpActionResult TraerVentas([FromUri]int clienteId)
        {
            try
            {
                var ventas = VentasRepository.TraerVentasDeCliente(clienteId);
                return Ok(ventas);
            }
            catch (Exception)
            {
                return BadRequest("No se pudo conectar a la base de datos");
            }
        }
    }
}
