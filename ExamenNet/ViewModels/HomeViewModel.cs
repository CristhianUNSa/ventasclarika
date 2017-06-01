using DAL;
using System.Collections.Generic;

namespace ExamenNet.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Cliente> Clientes { get; set; }
    }
}