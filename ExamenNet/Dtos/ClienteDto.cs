using System;

namespace ExamenNet.Dtos
{
    public class ClienteDto
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Telefono { get; set; }
    }
}