using DAL;
using DAL.Repositories;
using ExamenNet.Dtos;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace ExamenNet.Controllers.api
{
    public class ClientesController : ApiController
    {
        // POST: api/Clientes
        public async Task<IHttpActionResult> Post(ClienteDto clienteDto)
        {
            try
            {
                var cliente = new Cliente()
                {
                    FechaNacimiento = Convert.ToDateTime(clienteDto.FechaNacimiento),
                    Nombre = clienteDto.Nombre,
                    Telefono = clienteDto.Telefono
                };
                await ClientesRepository.AgregarCliente(cliente);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Hubo problemas con su solicitud");
            }

        }
    }
}
