using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class VentasRepository
    {
        public static IEnumerable<GetVentasByCliente_Result> TraerVentasDeCliente(int? clienteId)
        {
            using (var db = new VentasContext())
            {
                return db.GetVentasByCliente(clienteId).OrderByDescending(v => v.Cantidad).ToList();
            }
        }
    }
}