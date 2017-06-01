using DAL.Repositories;
using ExamenNet.Dtos;
using System.Web.Http;

namespace ExamenNet.Controllers.api
{
    public class VentasController : ApiController
    {
        [HttpGet]
        public IHttpActionResult TraerVentas(ClienteDto cliente)
        {
            var ventas = VentasRepository.TraerVentasDeCliente(cliente.ClienteID);
            return Ok(ventas);
        }
    }
}
