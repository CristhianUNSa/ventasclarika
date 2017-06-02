
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public static async Task AgregarCliente(Cliente cliente)
        {
            using (var db = new VentasContext())
            {
                db.Clientes.Add(cliente);
                await db.SaveChangesAsync();
            }
        }

    }
}
