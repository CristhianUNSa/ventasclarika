using DAL.Repositories;
using System.Web.Http;

namespace ExamenNet.Controllers.api
{
    public class VentasController : ApiController
    {
        [HttpGet]
        public IHttpActionResult TraerVentas([FromUri]int clienteId)
        {
            var ventas = VentasRepository.TraerVentasDeCliente(clienteId);
            return Ok(ventas);
        }
    }
}
