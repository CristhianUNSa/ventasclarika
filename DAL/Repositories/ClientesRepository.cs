
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class ClientesRepository
    {
        public static IEnumerable<Cliente> TraerClientes()
        {
            using (var db = new VentasContext())
            {
                return db.Clientes.ToList();
            }
        }

        public static void AgregarCliente(Cliente cliente)
        {
            using (var db = new VentasContext())
            {
                db.Clientes.Add(cliente);
            }
        }

    }
}
